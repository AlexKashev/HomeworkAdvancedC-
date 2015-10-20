using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("firstTask.txt"))
            {
                using (var writer = new StreamWriter("reversed.txt"))
                {
                    string line = reader.ReadLine();
                    int lineNumber = 0;

                    while (line != null)
                    {
                        lineNumber++;
                        writer.WriteLine("Line {0} {1}",lineNumber,line);
                        line = reader.ReadLine();

                    }

                    

                }
            }
        }
    }
}
