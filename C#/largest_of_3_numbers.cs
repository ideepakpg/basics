using System;

namespace largest_of_3_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Largest number is " + a);
                }
                else
                {
                    Console.WriteLine("Largest number is " + c);
                }
            }

            else
            {
                if (b > c)
                {
                    Console.WriteLine("Largest number is " + b);
                }
                else
                {
                    Console.WriteLine("Largest number is " + c);
                }
            }

            Console.ReadLine();

        }
    }
}
