using System;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the length of array");
            n = int.Parse(Console.ReadLine());

            int[] Ar = new int[n];
            Console.WriteLine("Enter the array element");

            for (int i = 0; i < n; i++)
            {
                Ar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array elements are : ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Ar[i]);
            }

            Console.ReadLine();

        }
    }
}
