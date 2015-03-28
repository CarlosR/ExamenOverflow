using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2IngSoft.Specs
{
    public static class FileReader
    {
        private static StreamReader _file;
        private static string _line;
        public static void OpenFile(string filePath)
        {
            _file = new StreamReader(filePath);
        }

        public static string SearchLine(string text)
        {
            while ((_line = _file.ReadLine()) != null)
            {
                if (_line.Contains(text)) 
                {
                    return _line;
                }
            }
            return string.Empty;
        }

        public static void CloseFile()
        {
            _file.Close();
        }
    }
}
