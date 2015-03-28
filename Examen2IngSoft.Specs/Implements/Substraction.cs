using Examen2IngSoft.Specs.Abstract_Classes;
using Examen2IngSoft.Specs.Interfaces;
using System.Collections.Generic;

namespace Examen2IngSoft.Specs.Implements
{
    public class Substraction : LogDecorator,IOperation
    {

        public Substraction(ILog newLog) : base(newLog)
        { 
        }

        public Substraction(ILog newLog, int result)
            : base(newLog)
        {
            SetLog(result);
        }

        public int Resolve(int num1, int num2)
        {
            return num1-num2;
        }

        public void SetLog(int result)
        {
            string line = "Resta " + result;
            OperationsLog = TempLog.GetLog();
            OperationsLog.Add(line);
        }

        public List<string> GetLog()
        {
            return OperationsLog;
        }
    }
}