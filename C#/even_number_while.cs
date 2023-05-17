using System;

namespace even_number_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            while (i < n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
