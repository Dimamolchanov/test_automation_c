using System.Diagnostics;

namespace test_automation.Utils
{
    public class CommonUtils
    {

        public static string ExecuteCMDCommand()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c taskkill /f /im chromedriver.exe";
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardError.ReadToEnd();
            process.WaitForExit();
            return output;
        }
    }
}
