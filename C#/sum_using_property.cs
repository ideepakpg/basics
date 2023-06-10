using System;

namespace sum_using_property
{
    class MyClass
    {
        public int a
        { get; set; }

        public int b
        { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            MyClass obj = new MyClass();
            Console.WriteLine("Enter two numbers");
            obj.a = int.Parse(Console.ReadLine());
            obj.b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum is {obj.a + obj.b}");

            Console.ReadLine();

        }
    }
}
