using System;

namespace task_property
{
    class A
    {
        public string Name
        { get; set; }

        public int Age
        { get; set; }
    }

    class B
    {
        public int Mark1
        { get; set; }

        public int Mark2
        { get; set; }
    }

    class C
    {
        public int x
        { get; set; }

        public int y
        { get; set; }
    }

    class D
    {
        public float a
        { get; set; }

        public float b
        { get; set; }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            A obj1 = new A();
            Console.WriteLine("Enter your name");
            obj1.Name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            obj1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hi {obj1.Name} Your age is {obj1.Age}");


            B obj2 = new B();
            Console.WriteLine("Enter your first mark");
            obj2.Mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second mark");
            obj2.Mark2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"First mark is {obj2.Mark2} Second mark is {obj2.Mark2}");


            C obj3 = new C();
            Console.WriteLine("Enter your first mark");   //to find SUM
            obj3.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second mark");
            obj3.y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total mark is {obj3.x + obj3.y}");


            D obj4 = new D();
            Console.WriteLine("Enter your first mark");
            obj4.a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second mark");
            obj4.b = float.Parse(Console.ReadLine());
            Console.WriteLine($"Average mark is {obj4.a / obj4.b}");


            Console.ReadLine();

        }
    }
}
