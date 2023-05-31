using System;

namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, i;
            Console.WriteLine("Enter any number to get the multiplication table");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {

                int result = n * i;
                Console.WriteLine($"{i}*{n}={result}");

            }


            Console.ReadLine();

        }
    }
}
