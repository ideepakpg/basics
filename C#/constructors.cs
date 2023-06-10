using System;

namespace constructors
{
    internal class Program
    {

        public Program()                               // default constructor
        {
            Console.WriteLine("Default Constructor");
        }

        public Program(int a, int b)                   // parameterized constructor
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        static Program()                               // static constructor -> no object is needed to be created ,calls automatically in static constructor
        {
            Console.WriteLine("Static Constructor");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            Program obj1 = new Program(10, 20);


            Console.ReadLine();

        }
    }
}
