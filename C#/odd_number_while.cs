using System;

namespace odd_number_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            Console.ReadLine();
        }
    }
}
