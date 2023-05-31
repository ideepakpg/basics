using System;

namespace mathematic_operations_using_function
{
    internal class Program
    {
        public int Addition() //with return value
        {
            int a, b, result;
            Console.WriteLine("Enter two numbers for Addition");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            result = a + b;
            Console.WriteLine("Addition is " + result);
            return result;
        }

        public void Subtraction() //without return value
        {
            int a, b;
            Console.WriteLine("Enter two numbers for Subtraction");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Subtraction is {0}", a - b);
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

        public void Multiplication()
        {
            int a, b, result;
            Console.WriteLine("Enter two numbers for Multiplication");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            result = a * b;
            Console.WriteLine("Multiplication is " + result); ;
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Addition();
            obj.Subtraction();
            obj.Division();
            obj.Multiplication();


            Console.ReadLine();


        }
    }
}
