using System;

namespace pattern_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i < n; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
