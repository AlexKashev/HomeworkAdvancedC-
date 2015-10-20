using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            StringBuilder word = new StringBuilder();
            foreach (char c in a)
            {
                word.Append("\\u");
                word.Append(String.Format("{0:x4}", (int)c));

            }
            Console.WriteLine(word.ToString());


        }
    }
}
