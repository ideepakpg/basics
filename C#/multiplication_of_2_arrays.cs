using System;

namespace multiplication_of_2_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, r, c, k;
            Console.WriteLine("Enter size of rows and coloumns");
            r = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (r == c)
            {
                int[,] a = new int[r, c];
                int[,] b = new int[r, c];
                int[,] d = new int[r, c];

                Console.WriteLine("Read first array elements");


                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Read second array elements");

                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        b[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        d[i, j] = 0;
                        for (k = 0; k < r; k++)
                        {
                            d[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }


                Console.WriteLine("Product of the given array elements are : ");

                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.Write(" " + d[i, j]);
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}

