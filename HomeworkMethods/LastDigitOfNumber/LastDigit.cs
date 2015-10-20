using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitOfNumber
{
    class LastDigit
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            last(a);
        }

        static void last(int num)
        {
            string[] number = { "zero", "one", "two", "three", "four", "five",
                              "six", "seven", "eight", "nine"};
            int lastDigit = num % 10;
            Console.WriteLine(number[lastDigit]);
        }
    }
}
