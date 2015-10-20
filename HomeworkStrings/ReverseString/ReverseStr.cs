using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseStr
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = new string(s.ToCharArray().Reverse().ToArray());
            Console.WriteLine(s);
            
        }
    }
}
