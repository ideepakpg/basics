using System;

namespace _2d_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, r, c;
            Console.WriteLine("Enter the size of rows and coloumns");
            r = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int[,] ar = new int[r, c];

            Console.WriteLine("Read array elements");

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    ar[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Array elements are");

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(" " + ar[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
