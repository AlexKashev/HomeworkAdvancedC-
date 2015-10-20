using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(<a)";
            string replace = "[URL";
            string pattern2 = @"(>)";
            string replace2 = "]";
            string pattern3 = "(</a>)";
            string replace3 = "[/URL]";
            var replaced = Regex.Replace(text, pattern, replace);
            var replaced2 = Regex.Replace(replaced, pattern3, replace3);
            var replaced3 = Regex.Replace(replaced2,pattern2,replace2);
            Console.WriteLine(replaced3);
        }
    }
}
