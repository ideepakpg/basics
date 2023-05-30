using System;

namespace reverse_pattern_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            for (i = n; i > 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
