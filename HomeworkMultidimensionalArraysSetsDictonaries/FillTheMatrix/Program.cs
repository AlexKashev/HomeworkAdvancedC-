using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] matrix = new int[a, b];
            int count = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0) {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {            
                        matrix[j, i] = count;                    
                        count++;
                        //matrix[i,j] = int.Parse( Console.ReadLine() );
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1)-1; j >= 0; j-- )
                    {            
                        matrix[j, i] = count;                    
                        count++;
                        //matrix[i,j] = int.Parse( Console.ReadLine() );
                    }
                }
                
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write( matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
