using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2IngSoft.Specs.Interfaces
{
    public interface ILog
    {
        List<string> OperationsLog { get; set; }

        void SetLog(int result);
        List<string> GetLog();
    }
}
