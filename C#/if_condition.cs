using System;

namespace if_condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if (num == 0)
            {
                Console.WriteLine("Number is Zero");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
            Console.ReadLine();

        }
    }
}
