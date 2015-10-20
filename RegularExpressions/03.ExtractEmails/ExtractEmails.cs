using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=\s|^)[a-z0-9]+[_.-]?[a-z0-9]*@[a-z]+\-?[a-z]+(\.[a-z]+)+\b";
            Regex regexMail = new Regex(pattern);
            MatchCollection matches = regexMail.Matches(text);
            foreach (Match name in matches)
            {
                Console.WriteLine(name.Groups[0]);
            }
        }
    }
}
