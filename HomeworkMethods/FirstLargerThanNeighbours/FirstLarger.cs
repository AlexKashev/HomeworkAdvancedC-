using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            Neighbours();
        }

        static void Neighbours()
        {
            string numbers = Console.ReadLine();
            int[] nums = numbers.Split().Select(int.Parse).ToArray();
            bool isTrue = false;

         

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    Console.WriteLine(i);
                    isTrue = true;
                    break;
                }
                else
                {
                    isTrue = false;
                }
               
           
            }
            if (isTrue == false)
            {

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < nums[i + 1])
                    {
                        Console.WriteLine("-1");
                        break;
                    }
                }
            }

           
        }
    }
}
