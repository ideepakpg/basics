using System;

namespace addition_of_two_2d_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, r, c;
            Console.WriteLine("Enter the size of rows and coloumns");
            r = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (r == c)
            {
                int[,] a = new int[r, c];
                int[,] b = new int[r, c];
                int[,] sum = new int[r, c];

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

                Console.WriteLine("Sum is : ");

                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        sum[i, j] = a[i, j] + b[i, j];
                        Console.WriteLine(sum[i, j]);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
