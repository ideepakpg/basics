using System;

namespace sum_of_array_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum = 0;
            Console.WriteLine("Enter the length of array");
            n = int.Parse(Console.ReadLine());

            int[] Ar = new int[n];
            Console.WriteLine("Enter the array element");

            for (i = 0; i < n; i++)
            {
                Ar[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; ++i)
            {
                sum = sum + Ar[i];
            }

            Console.WriteLine("Sum is : " + sum);
            Console.ReadLine();
        }
    }
}
