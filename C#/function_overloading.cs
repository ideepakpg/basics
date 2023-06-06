using System;

namespace function_overloading
{
    internal class Program
    {
        public void Sum()
        {
            int a, b;                                  // integer value
            Console.WriteLine("Enter two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum is {a + b}");
        }

        public void Sum(int a, int b)                  // integer value
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        public double Sum(double d1, double d2)        // double value
        {
            return (d1 + d2);
        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Sum();

            int a, b;
            Console.WriteLine("Enter two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            obj.Sum(a, b);

            double d1, d2;
            Console.WriteLine("Enter two numbers");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());

            double s = obj.Sum(d1, d2);
            Console.WriteLine("Sum is " + s);

            Console.ReadLine();


        }
    }
}
