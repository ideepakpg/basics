using System;

namespace calculator_using_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;
            Console.WriteLine("Enter two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator");
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine("Addition is " + result);
                    break;
                case "-":
                    result = a - b;
                    Console.WriteLine("Subtraction is " + result);
                    break;
                case "*":
                    result = a * b;
                    Console.WriteLine("Multiplication is " + result);
                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine("Division is " + result);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

                    Console.ReadLine();
            }
        }
    }
}
