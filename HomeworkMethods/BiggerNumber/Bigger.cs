using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class Bigger
    {
        static void Main(string[] args)
        {
           
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            BigNumber(first,second);

            
        }

        static void BigNumber(int a,int b)
        {
            
            if (a>b)
            {
                Console.WriteLine(a);
            }
            else 
            {
                Console.WriteLine(b);
            }
        }
    }
}
