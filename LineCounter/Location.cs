using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCounter
{
    public static class Location
    {
        public static string TFSPath { get { return _tfsPath; } set { value = _tfsPath; } }

        public static string FilePath = "Result.txt";

        public static long Count = 0;

        public static bool LoopResult;

        private static readonly string _tfsPath;

        static Location()
        {
            _tfsPath = ConfigurationManager.AppSettings["TFSPath"].ToString();
            

        }


        public static void  CountNumberOfLines()
        {

            var fileNames = Util.AllFiles(TFSPath);

            StringBuilder db = new StringBuilder();
             foreach (var fileName in fileNames)
            {

                db.Append(fileName);
                db.Append(" : ");
                Location.Count += Location.CountLinesInFile(fileName);
                db.Append(Location.Count.ToString());
                db.AppendLine();
              }

            File.WriteAllText(FilePath, db.ToString());

        }

      
        public static long CountLinesInFile(string fileName)
        {
            long count = 0;
            using (StreamReader r = new StreamReader(fileName))
            {
                string line;
                
                    while ((line = r.ReadLine()) != null)
                    {
                        count++;
                    }
                
                
            }
            return count;
        }
    }
}
