using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            Neighbours();
        }

        static void Neighbours()
        {
            string numbers = Console.ReadLine();
            int[] nums = numbers.Split().Select(int.Parse).ToArray();
            bool isLarger = true;
            int a = 0;

            if (nums[0] > nums[1])
            {
                isLarger = true;
                Console.WriteLine(isLarger);
            }
            else
            {
                isLarger = false;
                Console.WriteLine(isLarger);
            }

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i - a] < nums[i] && nums[i] > nums[i + 1])
                {
                    isLarger = true;
                    Console.WriteLine(isLarger);
                }
                else
                {
                    isLarger = false;
                    Console.WriteLine(isLarger);
                }
                a = 1;

            }


            if (nums[nums.Length - 1] > nums[nums.Length - 2])
            {
                isLarger = true;
                Console.WriteLine(isLarger);
            }
            else
            {
                isLarger = false;
                Console.WriteLine(isLarger);
            }
        }
    }
}
