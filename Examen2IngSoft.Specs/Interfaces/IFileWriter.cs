using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2IngSoft.Specs.Interfaces
{
    public interface IFileWriter
    {
        void WriteLog(List<string> logList);
    }
}
