using Examen2IngSoft.Specs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2IngSoft.Specs.Implements
{
    public class BaseLog : ILog
    {
        public List<string> OperationsLog { get; set; }

        public BaseLog(){
            OperationsLog = new List<string>();

        }

        public void SetLog(int result)
        {
            //string line = "There was no operation " + result;
            //OperationsLog.Add(line);
        }

        public List<string> GetLog()
        {
            return OperationsLog;
        }

    }
}
