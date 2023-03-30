﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp.Code
{
    internal class Actions
    {
        //fields
        private readonly string _message1;
        private readonly string _message2;
        public readonly string _message3;
        //properties
        //constructor
        public Actions()
        {
            _message1 = "Start method: Method1()";
            _message2 = "Skipped logic in method: Method2()";
            _message3 = "I broke a logic: Method3()";
        }
        //public & private methods
        public Result Method1()
        {
            Logger _logger = new Logger();
            _logger.DisplayLog(LogType.Info, _message1);

            return new Result(true);
        }
        public Result Method2()
        {
            Logger _logger = new Logger();
            _logger.DisplayLog(LogType.Warning, _message2);
            return new Result(true);
        }
        public Result Method3()
        {
            return new Result(false, _message3);
        }
    }
}
