using System.Text;

namespace AutoUnlockMusicClient.config;

public class SoftOptions
{
    /// <summary>
    /// 监听(输入)目录
    /// </summary>
    public string InputPath { get; set; } = string.Empty;

    /// <summary>
    /// 输出目录
    /// </summary>
    public string OutputPath { get; set; } = string.Empty;

    /// <summary>
    /// 是否删除源文件
    /// </summary>
    public bool IsDeleteOrigin { get; set; }

    /// <summary>
    /// 心跳间隔(秒)
    /// </summary>
    public int HeartbeatInterval { get; set; } = 30;

    /// <summary>
    /// 重试间隔(秒)
    /// </summary>
    public int RetryDelayInterval { get; set; } = 10;

    /// <summary>
    /// 最大重试次数
    /// </summary>
    public int MaxRetries { get; set; } = 6;

    public void SaveOptions()
    {
        var fs = new FileStream("config.json", FileMode.Create);
        var sw = new StreamWriter(fs, Encoding.UTF8);
        var json = this.ObjectToJson();
        sw.WriteAsync(json);
        sw.Flush();
        sw.Close();
        sw.Dispose();
        fs.Close();
        fs.Dispose();
    }

    public SoftOptions ReadOptions()
    {
        if (!File.Exists("config.json")) File.WriteAllText("config.json", "{}", Encoding.UTF8);
        var fs = new FileStream("config.json", FileMode.OpenOrCreate);
        var sr = new StreamReader(fs, Encoding.UTF8);
        var json = sr.ReadToEnd();
        var options = json.JsonToObject<SoftOptions>();

        sr.Close();
        sr.Dispose();
        fs.Close();
        fs.Dispose();
        return options;
    }
}