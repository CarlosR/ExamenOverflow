using Examen2IngSoft.Specs.Abstract_Classes;
using Examen2IngSoft.Specs.Interfaces;
using System.Collections.Generic;

namespace Examen2IngSoft.Specs.Implements
{
    public class Addition:LogDecorator,IOperation
    {

        public Addition(ILog newLog) : base(newLog)
        { 
        }

        public Addition(ILog newLog, int result)
            : base(newLog)
        {
            SetLog(result);
        }

        public int Resolve(int num1, int num2)
        {
            return num1 + num2;
        }

        public void SetLog(int result)
        {
            string line = "Suma " + result;
            OperationsLog = TempLog.GetLog();
            OperationsLog.Add(line);
        }

        public List<string> GetLog()
        {
            return OperationsLog;
        }
    }
}
