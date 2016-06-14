using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given TFS Path is {0}", Location.TFSPath);
            Console.WriteLine("Counting the total number of lines......");
            Location.CountNumberOfLines();
            Console.WriteLine("Total Number Of Lines {0}", Location.Count);
            Console.ReadLine();
        }
    }
}
