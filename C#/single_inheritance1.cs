using System;

namespace single_inheritance1
{
    class ParentClass  //Base class
    {
        public void Display()
        {
            Console.WriteLine("This is a message");
        }

        public void Print()
        {
            Console.WriteLine("Printing some message");
        }
    }
    internal class Program : ParentClass
    {
        public void Show()
        {
            Console.WriteLine("Show message");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Display();
            obj.Print();
            obj.Show();

            Console.ReadLine();

        }
    }
}
