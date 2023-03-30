using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp.Code
{
    internal class Actions
    {
        private readonly string _message1;
        private readonly string _message2;
        private readonly string _message3;

        public Actions()
        {
            _message1 = "Start method: Method1()";
            _message2 = "Skipped logic in method: Method2()";
            _message3 = "I broke a logic: Method3()";
        }

        public string Message3 { get; set; }
        public Result Method1()
        {
            Logger logger = new Logger();
            logger.DisplayLog(LogType.Info, _message1);
            return new Result(true);
        }

        public Result Method2()
        {
            Logger logger = new Logger();
            logger.DisplayLog(LogType.Warning, _message2);
            return new Result(true);
        }

        public Result Method3()
        {
            return new Result(false, _message3);
        }
    }
}
