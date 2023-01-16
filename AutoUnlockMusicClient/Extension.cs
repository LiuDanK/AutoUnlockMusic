using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;

namespace AutoUnlockMusicClient;

public static class Extension
{
    /// <summary>
    /// 执行命令行
    /// </summary>
    public static async Task<string> ExecuteCommandLine(this string shell, bool isAppendExit = true)
    {
        var process = new Process
        {
            StartInfo =
            {
                FileName = "cmd.exe",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                StandardErrorEncoding = Encoding.Default
            }
        };
        if (isAppendExit)
        {
            shell += "&exit";
        }
        process.Start();
        await process.StandardInput.WriteLineAsync(shell);
        var error = await process.StandardError.ReadToEndAsync();//错误信息
        await process.WaitForExitAsync();
        process.Close();
        process.Dispose();
        return error;
    }

    public static string ObjectToJson(this object obj) => JsonConvert.SerializeObject(obj);

    public static T JsonToObject<T>(this string json) => JsonConvert.DeserializeObject<T>(json);
}