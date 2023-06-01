using System;

namespace multilevel_inheritance2
{
    class MultilevelInheritance
    {
        public int a, b;
        public void Read()
        {
            Console.WriteLine("Enter 2 numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
    }

    class A : MultilevelInheritance
    {
        public int s;
        public void Sum()
        {
            s = a + b;
            Console.WriteLine("Sum is " + s);
        }

    }

    class B : A
    {
        public void Average()
        {
            int average = a / b;
            Console.WriteLine("Average is {0} ", a / b);  //Console.WriteLine("Average is " + average);//
        }
    }
    internal class Program : B
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Read();
            obj.Sum();
            obj.Average();


            Console.ReadLine();

        }
    }
}
