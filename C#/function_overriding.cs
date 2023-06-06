using System;

namespace function_overriding
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Base class method");
        }
    }

    class Program : A
    {
        public override void Display()
        {
            Console.WriteLine("Derived class method");
        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Display();

            Console.ReadLine();

        }
    }
}
