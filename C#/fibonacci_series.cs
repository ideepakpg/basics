using System;

namespace fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c = 0;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci series are : ");
            Console.WriteLine(a);
            Console.WriteLine(b);

            while (2 < n)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                n--;
            }
            Console.ReadLine();
        }
    }
}
