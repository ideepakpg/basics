using System;

namespace function
{
    internal class Program
    {

        // without return value
        public void Substraction()
        {
            int a, b, result;
            Console.WriteLine("Enter two numbers for Subtraction");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            result = a - b;

            Console.WriteLine("Subtraction is " + result);
        }

        // with return value
        public int Multiplication()
        {
            int a, b, result;
            Console.WriteLine("Enter two numbers for Multiplication");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            result = a * b;

            Console.WriteLine("Multiplication is " + result);
            return result;
        }

        public int Addition()
        {
            int a, b, result;
            Console.WriteLine("Enter two numbers for Addition");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            result = a + b;

            Console.WriteLine("Addition is " + result);
            return result;
        }

        public int Division()
        {
            int a, b, result;
            Console.WriteLine("Enter two numbers for Division");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            result = a / b;

            Console.WriteLine("Division is " + result);
            return result;
        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Substraction();
            obj.Multiplication();
            obj.Addition();
            obj.Division();


            Console.ReadLine();


        }
    }
}
