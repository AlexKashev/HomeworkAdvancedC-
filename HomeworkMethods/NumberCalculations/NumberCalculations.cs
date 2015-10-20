using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            decimal[] decimals = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            double[] doubles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine("Min is {0}",Min(decimals));
            Console.WriteLine("Min is {0}",Min(doubles));
            Console.WriteLine("Max is {0}",Max(decimals));
            Console.WriteLine("Max is {0}",Max(doubles));
            Console.WriteLine("Sum is {0}",Sum(decimals));
            Console.WriteLine("Sum is {0}",Sum(doubles));
            Console.WriteLine("Avg is {0}",Average(decimals));
            Console.WriteLine("Avg is {0}",Average(doubles));
            Console.WriteLine("Product is {0}",Product(decimals));
            Console.WriteLine("Product is {0}",Product(doubles));
        }
        static double Min(double[] nums)
        {
            double min = double.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (min>nums[i])
                {
                    min=nums[i];
                }
                
            }
            return min;
        }
        static decimal Min(decimal[] nums)
        {
            decimal min = decimal.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (min >= nums[i])
                {
                    min = nums[i];
                }

            }
            return min;
        }
        static double Max(double[] nums)
        {
            double max = double.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max<nums[i])
                {
                    max = nums[i];
                }
            }
            return max;
        }
        static decimal Max(decimal[] nums)
        {
            decimal max = decimal.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            return max;
        }
        static double Sum(double[]nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static decimal Sum(decimal[] nums)
        {
            decimal sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        
        static double Product(double[]nums)
        {
            double product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
            }
            return product;
        }

        static decimal Product(decimal[] nums)
        {
            decimal product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
            }
            return product;
        }
        static double Average(double[] nums)
        {
            return Sum(nums) / nums.Length;
        }

        static decimal Average(decimal[] nums)
        {
            return Sum(nums) / nums.Length;
        }
    }
}
