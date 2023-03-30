using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp.Code
{
    internal class Starter
    {
        //fields
        //properties
        //constructor
        //public & private methods
        public void Run()
        {
            Actions action = new Actions();
            Result result = new Result();
            Logger _logger = new Logger();

            for (int i = 0; i < 100; i++)
            {
                int choice = new Random().Next(1, 4);
                switch (choice)
                {
                    case 1:
                        action.Method1();
                        break;
                    case 2:
                        action.Method2();
                        break;
                    case 3:
                        action.Method3();
                        if (result.Status == false)
                        {
                            Logger logger1 = new Logger();
                            string errorMsg = "Action failed by а reason:";
                            logger1.DisplayLog(LogType.Error, $"{errorMsg} {action._message3}");
                        }
                        break;
                    default:
                        Console.WriteLine("No one method enter the switcher");
                        break;
                }
            }
            _logger.WriteFile();
        }

    }
}
