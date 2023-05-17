using System;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("The even number is " + i);
                }
            }
            Console.ReadLine();
        }
    }
}
