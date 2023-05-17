using System;

namespace smallest_of_2_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("Smallest number is " + num1);
            }

            else
            {
                Console.WriteLine("Smallest number is " + num2);
            }

            Console.ReadLine();
        }
    }
}
