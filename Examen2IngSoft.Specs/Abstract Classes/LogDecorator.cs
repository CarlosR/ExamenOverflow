using Examen2IngSoft.Specs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2IngSoft.Specs.Abstract_Classes
{
    public abstract class LogDecorator : ILog
    {
        protected ILog TempLog;
        public List<string> OperationsLog { get; set; }

        public LogDecorator(ILog newLog) 
        {
            TempLog = newLog;
        }

        public List<string> GetLog()
        {
            return TempLog.GetLog();
        }

        public void SetLog(int result)
        {
            OperationsLog = TempLog.OperationsLog;
        }
    }
}
