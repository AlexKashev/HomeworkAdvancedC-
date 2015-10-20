using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.SeriesOfLetters
{
    class SerisOfLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex("(.)\\1+");
            Console.WriteLine(regex.Replace(text, "$1"));
        }
    }
}
