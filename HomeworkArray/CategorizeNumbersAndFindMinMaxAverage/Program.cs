using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNumbersAndFindMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            float[] nums = number.Split().Select(float.Parse).ToArray();
            List<float> roundList = new List<float>();
            List<float> nonRoundList = new List<float>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 1 == 0)
                {
                    roundList.Add(nums[i]);
                }
                else
                {
                    nonRoundList.Add(nums[i]);
                }
            }

            roundList.Sort();
            nonRoundList.Sort();

           float firstRound = roundList.FirstOrDefault();
           float firstNonRound = nonRoundList.FirstOrDefault();
           float lastRound = roundList.LastOrDefault();
           float lastNonRound = nonRoundList.LastOrDefault();
           float sumRound = roundList.Sum();
           float sumNonRound = nonRoundList.Sum();
           float avgRound = sumRound / roundList.Count;
           float avgNonRound = sumNonRound / nonRoundList.Count;

           foreach (var item in roundList)
           {
               Console.Write(item + " ");
           }




           Console.WriteLine(" -> min : {0}, max: {1}, sum: {2}, avg: {3:F2}", firstRound, lastRound, sumRound, avgRound);
           foreach (var item in nonRoundList)
           {
               Console.Write(item + " ");
           }
            Console.WriteLine(" -> min : {0}, max: {1}, sum: {2}, avg: {3:F2}", firstNonRound, lastNonRound,sumNonRound,avgNonRound);


        }
    }
}
