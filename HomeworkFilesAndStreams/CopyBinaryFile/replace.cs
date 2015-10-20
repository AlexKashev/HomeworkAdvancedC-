using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        const string file = @"../../Program.cs";
        const string copied = @"../../replace.cs";

        static void Main(string[] args)
        {
            using (var source = new FileStream(file, FileMode.Open))
            {
                using (var destination = new FileStream(copied, FileMode.Create))
                {
                    double fileLength = source.Length;
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);

                    }
                }

            }
        }
    } 
}
