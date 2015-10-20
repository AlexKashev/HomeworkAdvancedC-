using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            string other;

            string[,] matrix = new string[a, b];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            string n = Console.ReadLine();
            while( n != "END" ){
                if (n.Contains("swap"))
                {
                    n = n.Replace("swap ", "");
                    int[] m = n.Split().Select(int.Parse).ToArray();

                    //m[0] = x1
                    //m[1] = y1
                    //m[2] = x2
                    //m[3] = y2

                    if (m[0] < a && m[1] < b && m[2] < a && m[3] < b)
                    {
                        other = matrix[m[0], m[1]];
                        matrix[m[0], m[1]] = matrix[m[2], m[3]];
                        matrix[m[2], m[3]] = other;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
     
                n = Console.ReadLine();
            }
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
