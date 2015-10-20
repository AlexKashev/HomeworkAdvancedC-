using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedNumbers
{
    class ReversedNumbers
    {
        static void Main()
        {
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Reversed: {0}", ReverseNumber(d));
        }

        static double ReverseNumber(double number)
        {
            return double.Parse(ReverseString(number.ToString()));
        }

       static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
