using System;

namespace matrix_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, r1, r2, c1, c2;
            Console.WriteLine("Enter the size of first array");
            r1 = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine());

            int[,] a = new int[r1, c1];

            Console.WriteLine("Enter the elements of the first array");

            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("Enter the size of the second array");
            r2 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine());

            int[,] b = new int[r2, c2];

            Console.WriteLine("Enter the elements of the second array");

            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Product of the given two arrays");

            int[,] s = new int[c1, c2];

            for (i = 0; i < c1; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    s[i, j] = 0;

                    for (k = 0; k < r2; k++)
                    {
                        s[i, j] += a[i, k] * b[k, j];
                    }
                }

                Console.WriteLine();
            }


            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write(s[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
