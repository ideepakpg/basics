using System;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, f = 1;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial is " + f);
            Console.ReadLine();
        }
    }
}
