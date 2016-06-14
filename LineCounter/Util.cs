using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCounter
{
    public class Util
    {

        public static ICollection<string>  AllFiles(string path)
        {
            string[] filePaths = Directory.GetFiles(path, "*.cs",
                                         SearchOption.AllDirectories).ToArray();
            

            return filePaths;

        }

       
    }
}
