using System;

namespace odd_or_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numbers");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

            Console.ReadLine();

        }
    }
}
