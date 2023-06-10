using System;

namespace abstract_class
{

    abstract class A
    {
        public void Display()
        {
            Console.WriteLine("Non abstract method");
        }
        public abstract void AbstractFunction();
    }
    class Program : A
    {
        public override void AbstractFunction()
        {
            Console.WriteLine("Abstract method");
        }

        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Display();
            obj.AbstractFunction();

            Console.ReadLine();

        }
    }
}
