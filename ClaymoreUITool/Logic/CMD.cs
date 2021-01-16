using System;
using System.Diagnostics;

namespace ClaymoreUITool.Logic
{
    public class CMD
    {
        public static void execute(string command)
        {
            try
            {
                Process.Start("EthDcrMiner64.exe", command);
            }
            catch (Exception)
            {
                Tasks
                    .MESSAGEBOX("EthDcrMiner64.exe file not found. Please, place the application a valid Claymore Ethereum folder."
                    , "Not Claymore folder"
                    , System.Windows.Forms.MessageBoxButtons.OK
                    , System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void runClaymore(string miningAccountName, string workerGroupName, string gpuUsage)
        {
            string command = "-epool ethash.poolbinance.com:8888 -ewal " +
                miningAccountName + " -eworker " +
                workerGroupName + " -li " +
                calculateGpuUsage(gpuUsage) + " -epsw x -asm 2 -dbg -1 -allpools 1 -mode 1 ";
            Console.WriteLine(command);
            execute(command);
        }

        public static string calculateGpuUsage(string gpuUsage)
        {
            if (Int32.TryParse(gpuUsage, out int number))
            {
                int value = Int32.Parse(gpuUsage);
                if (value > 100)
                {
                    return "0";
                }

                if (value <= 0)
                {
                    return "0";
                }
                /*
                 Example-> value = 30.
                -li must be "-li 70"
                30 - 100 = 70.
                 */
                return "" + (100 - value);
            }
            return "0";
        }
    }
}
