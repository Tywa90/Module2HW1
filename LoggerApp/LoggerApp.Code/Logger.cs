using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp.Code
{
    internal class Logger
    {
        private static string logConsole;
        static StringBuilder sb = new StringBuilder();

        public void DisplayLog(LogType type, string message)
        {
            logConsole = DateTime.Now.ToString() + " : " + type + " : " + message;
            Console.WriteLine(logConsole);
            var temp = sb.Append(logConsole + "\n");
            sb = temp;
        }
        public void WriteFile()
        {
            var textLog = sb.ToString();

            File.WriteAllText("log.txt", textLog);
        }
    }
}
