using System;

namespace properties
{
    class MyClass
    {
        public int pname
        { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            MyClass obj = new MyClass();
            obj.pname = 100;
            Console.WriteLine($"Value of x is {obj.pname}");

            Console.ReadLine();

        }
    }
}
