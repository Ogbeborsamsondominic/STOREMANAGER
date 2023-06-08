using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.WriteOrReadJson
{
       public class JsonHelper
    {
        public static string GetPath(string fileName)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(
            Path.GetFullPath(Path.Combine(currentDir, @"..\..\..\" + fileName)));
            return directory.FullName;
        }
    }
}
