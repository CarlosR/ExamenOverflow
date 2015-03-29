using Examen2IngSoft.Specs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2IngSoft.Specs.Implements
{
    class FileWriter : IFileWriter
    {
        public void WriteLog(List<string> logList) 
        {
            System.IO.File.WriteAllLines(@"Log.txt", logList.ToArray());
        }
    }
}
