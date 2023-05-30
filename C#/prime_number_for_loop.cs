using System;

namespace prime_number_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i < n; i++)
            {
                int c = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
