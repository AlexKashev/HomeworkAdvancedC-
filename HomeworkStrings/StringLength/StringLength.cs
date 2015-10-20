using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.Write(a);

            for (int i = a.Length; i < 20; i++)
            {
                Console.Write("*");
            }
            
           
        }
    }
}
