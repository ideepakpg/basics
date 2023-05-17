using System;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
