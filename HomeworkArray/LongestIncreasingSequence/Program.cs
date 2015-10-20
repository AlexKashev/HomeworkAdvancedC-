using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] nums = numbers.Split().Select(int.Parse).ToArray();
            int j = 0;
            List<int> current = new List<int>();
            List<int> longest  = new List<int>();

            for (int i = 0; i < nums.Length-1; i++)
            {

                Console.Write(nums[i] + " ");
                j = i + 1;

                current = new List<int>();
                current.Add(nums[i]);
                while (j < nums.Length && nums[j] > nums[i])
                {
                    Console.Write(nums[j] + " ");
                    current.Add(nums[j]);
                    j++;
                    i++;                    
                }
                Console.WriteLine();
                if (current.Count>longest.Count)
                {
                    longest = current;
                }
            }
            foreach (var item in longest)
            {
                Console.Write( item ); 
            }
        }
    }
}
