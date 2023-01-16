using AutoUnlockMusicClient.config;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using SageTools.Utils;
using static AutoUnlockMusicClient.GlobalConst;

namespace AutoUnlockMusicClient
{
    public partial class FrmMain : FrmWithTitle
    {
        #region Fields & Ctor

        private readonly SoftOptions _softOptions;
        private readonly string _umPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"source\um.exe");

        /// <summary>
        /// 闲置时间(用于计算输出心跳监听)
        /// </summary>
        private int _idleTime;

        public FrmMain(SoftOptions softOptions)
        {
            InitializeComponent();
            _softOptions = softOptions;
            log_timer.Start();
        }

        #endregion Fields & Ctor

        private void Timer_Tick(object? sender, EventArgs e)
        {
            _idleTime += 1;
            if (_softOptions.HeartbeatInterval > 0 && _idleTime < _softOptions.HeartbeatInterval) return;
            PrintInfoLog("程序没有挂，还在干活呢......");
            _idleTime = 0;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            BindControl();
            WatchDir(_softOptions.InputPath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _softOptions.SaveOptions();
            PrintSuccessLog("配置已保存");
        }

        private void BindControl()
        {
            txt_InputPath.DataBindings.Add("Text", _softOptions, nameof(_softOptions.InputPath));
            txt_OutputPath.DataBindings.Add("Text", _softOptions, nameof(_softOptions.OutputPath));
            txt_HeartbeatInterval.DataBindings.Add("Text", _softOptions, nameof(_softOptions.HeartbeatInterval));
            txt_MaxRetries.DataBindings.Add("Text", _softOptions, nameof(_softOptions.MaxRetries));
            txt_RetryDelayInterval.DataBindings.Add("Text", _softOptions, nameof(_softOptions.RetryDelayInterval));
            switch_IsDeleteOrigin.DataBindings.Add("Checked", _softOptions, nameof(_softOptions.IsDeleteOrigin));
            PrintSuccessLog("程序启动，配置已加载");
        }

        #region 文件监听

        private void WatchDir(string path)
        {
            if (!File.Exists(path) && !Directory.Exists(path))
            {
                PrintErrorLog("监听目录/文件不存在");
                return;
            }
            var watcher = new FileSystemWatcher(path);
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
            watcher.Created += FileWatcher_Created;
            PrintInfoLog($"监听目录：{_softOptions.InputPath}，输出目录：{_softOptions.OutputPath} 监听中......");
        }

        private void FileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            if (e.Name.ToLower().EndsWith(".lrc")) return;
            while (true)
            {
                FileStream stream = null;
                try
                {
                    stream = new FileStream(e.FullPath, FileMode.Open);
                    break;
                }
                catch
                {
                    Task.Delay(1000).Wait();
                }
                finally
                {
                    stream?.Close();
                    stream?.Dispose();
                }
            }
            PrintInfoLog($"监听到新文件：{e.Name}");
            var executeResult = ExeShellAndFormatLog($"{_umPath} -i \"{e.FullPath}\" -o \"{_softOptions.OutputPath}\"").Result;
            if (!executeResult || !_softOptions.IsDeleteOrigin) return;
            var deleteResult = ExtensionUtils.DelayRetry(() =>
            {
                File.Delete(e.FullPath);
                return true;
            }, x => x, 10);
            if (deleteResult) PrintInfoLog("源文件已删除");
        }

        #endregion 文件监听

        #region 执行转换

        private async Task<bool> ExeShellAndFormatLog(string shell)
        {
            //延迟重试执行
            var executeResult = await ExtensionUtils.DelayRetryAsync(async () =>
            {
                var log = string.Empty;
                var output = await shell.ExecuteCommandLine();
                if (output.Contains("successfully"))
                {
                    var json = JsonConvert.DeserializeObject<dynamic>(output[output.LastIndexOf('{')..]);
                    log += $"处理成功，输出文件 {json!.destination}";
                    PrintSuccessLog(log);
                    return true;
                }
                if (output.Contains("error"))
                {
                    var json = JsonConvert.DeserializeObject<dynamic>(output[output.LastIndexOf('{')..]);
                    log += "处理失败 " + json.error;
                    PrintErrorLog(log);
                }
                else
                {
                    log += $"未知错误 {output}";
                    PrintErrorLog(log);
                }

                if (_softOptions.MaxRetries > 0)
                {
                    PrintInfoLog($"{_softOptions.RetryDelayInterval}秒后重试......");
                }
                return false;
            }, x => x, _softOptions.MaxRetries, _softOptions.RetryDelayInterval * 1000);
            return executeResult;
        }

        #endregion 执行转换

        #region Print Log

        private void PrintInfoLog(string log, bool isPrintTime = true)
        {
            if (isPrintTime)
            {
                log = $"{DateTime.Now:HH:mm:ss}》" + log;
            }
            log += Environment.NewLine;
            Invoke(SetLogTextBoxText, log, LogLevel.Info);
        }

        private void PrintSuccessLog(string log, bool isPrintTime = true)
        {
            if (isPrintTime)
            {
                log = $"{DateTime.Now:HH:mm:ss}》" + log;
            }
            log += Environment.NewLine;
            Invoke(SetLogTextBoxText, log, LogLevel.Success);
        }

        private void PrintErrorLog(string log, bool isPrintTime = true)
        {
            if (isPrintTime)
            {
                log = $"{DateTime.Now:HH:mm:ss}》" + log;
            }
            log += Environment.NewLine;
            Invoke(SetLogTextBoxText, log, LogLevel.Error);
        }

        #endregion Print Log

        #region 委托方法

        /// <summary>
        /// 设置日志控件值
        /// </summary>
        /// <param name="text"></param>
        /// <param name="logLevel">1=Info 2=Success 3=Error</param>
        private void SetLogTextBoxText(string text, LogLevel logLevel = LogLevel.Info)
        {
            log_richTextBox.SelectionStart = log_richTextBox.TextLength;
            log_richTextBox.SelectionLength = 0;
            log_richTextBox.SelectionColor = logLevel switch
            {
                LogLevel.Info => Color.Black,
                LogLevel.Success => Color.Green,
                LogLevel.Error => Color.Red,
                _ => log_richTextBox.ForeColor
            };
            log_richTextBox.AppendText(text);
            log_richTextBox.SelectionColor = log_richTextBox.ForeColor;

            log_richTextBox.SelectionStart = log_richTextBox.TextLength;
            log_richTextBox.ScrollToCaret();

            _idleTime = 0;
        }

        #endregion 委托方法

        #region 配置

        private SoftOptions ReadConfig()
        {
            var fileStream = new FileStream(@"config.json", FileMode.OpenOrCreate);
            var readStream = new StreamReader(fileStream);
            var json = readStream.ReadToEnd();
            var options = JsonConvert.DeserializeObject<SoftOptions>(json);
            options ??= new SoftOptions();
            return options;
        }

        #endregion 配置
    }
}