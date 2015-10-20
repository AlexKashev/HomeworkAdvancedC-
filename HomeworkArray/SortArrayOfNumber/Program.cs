using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int[] nums = number.Split().Select(int.Parse).ToArray();
            Array.Sort(nums);
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
