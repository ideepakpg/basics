using System;

namespace sum_of_2d_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j, i, r, c, sum = 0;
            Console.WriteLine("Enter the size of row and coloumn");
            r = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int[,] arr = new int[r, c];

            Console.WriteLine("Read array elements");

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    sum = sum + arr[i, j];
                }
            }

            Console.WriteLine("Sum is " + sum);

            Console.ReadLine();
        }
    }
}
