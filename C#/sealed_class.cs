using System;

namespace sealed_class
{
    sealed class A
    {
        public void Display()
        {
            Console.WriteLine("Sealed Class");
        }
    }
    class Program
    {
        public void Display()
        {
            Console.WriteLine("Non Sealed Class");
        }

        static void Main(string[] args)
        {

            A obj = new A();
            Program obj1 = new Program();
            obj.Display();
            obj1.Display();

            Console.ReadLine();

        }
    }
}
