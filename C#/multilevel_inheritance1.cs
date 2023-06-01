using System;

namespace multilevel_inheritance1
{
    class A
    {
        public void Function1()
        {
            Console.WriteLine("This is a function from class A");
        }
    }

    class B : A
    {
        public void Function2()
        {
            Console.WriteLine("This is a function from class B");
        }
    }
    internal class Program : B
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Function1();
            obj.Function2();

            Console.ReadLine();


        }
    }
}
