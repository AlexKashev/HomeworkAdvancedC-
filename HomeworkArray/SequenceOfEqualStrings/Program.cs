using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] other = new string[input.Length];

            for (int i = 0; i < input.Length-1; i++)
            {
               
                if ( ! other.Contains(input[i]))
                {
                    other[i] = input[i];
                    Console.Write(input[i] + " ");
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[i].Equals(input[j]))
                        {
                            Console.Write(input[j] + " ");
                        }
                    } Console.WriteLine();
                }
               
            }
        }
    }
}
