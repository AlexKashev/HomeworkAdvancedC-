using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequeneInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            List<string> longest = new List<string>();
            List<string> current = new List<string>();

            string[,] matrix = new string[a,b];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[j, i] == matrix[j + 1, i])
                    {
                        if (current.Count == 0)
                        {
                            current.Add(matrix[j, i]);
                        }
                        current.Add(matrix[j + 1, i]);
                    }
                    else
                    {
                        if (current.Count > longest.Count)
                        {
                            longest.Clear();
                            longest.AddRange(current);

                        }
                        current.Clear();
                    }
                }
                if (current.Count > longest.Count)
                {
                    longest.Clear();
                    longest.AddRange(current);

                }
                current.Clear();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        if (current.Count == 0)
                        {
                            current.Add(matrix[i, j]);
                        }
                        current.Add(matrix[i, j + 1]);
                    }
                    else
                    {
                        if (current.Count > longest.Count)
                        {
                            longest.Clear();
                            longest.AddRange(current);

                        }
                        current.Clear();
                    }
                }
                if (current.Count > longest.Count)
                {
                    longest.Clear();
                    longest.AddRange(current);

                }
                current.Clear();
            }

            int index = 0;
            while (index < matrix.GetLength(0) - 1)
            {
                int k = index;
                int l = 0;
                while (k < matrix.GetLength(0) - 1 && l < matrix.GetLength(1) - 1)
                {
                    if (matrix[k, l] == matrix[k + 1, l + 1])
                    {
                        if (current.Count == 0)
                        {
                            current.Add(matrix[k, l]);
                        }
                        current.Add(matrix[k + 1, l + 1]);
                    }
                    else
                    {
                        if (current.Count > longest.Count)
                        {
                            longest.Clear();
                            longest.AddRange(current);

                        }
                        current.Clear();
                    }                 

                    k++;
                    l++;
                }
                if (current.Count > longest.Count)
                {
                    longest.Clear();
                    longest.AddRange(current);

                }
                current.Clear();

                index++;
            }


            Console.WriteLine();
            foreach (var item in longest)
            {
                Console.Write(item+ " ");
            }

        }
    }
}
