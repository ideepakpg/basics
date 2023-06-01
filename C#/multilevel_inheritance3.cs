using System;

namespace multilevel_inheritance3
{
    class A
    {
        public string name;
        public int age;

        public void Read()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
        }
    }

    class B : A
    {
        public int mark1, mark2;

        public void Mark()
        {
            Console.WriteLine("Enter your first mark");
            mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second mark");
            mark2 = int.Parse(Console.ReadLine());
        }
    }

    class C : B
    {
        public int sum, average;

        public void Print()
        {
            Console.WriteLine("Enter marks of 2 subjects for SUM");
            mark1 = int.Parse(Console.ReadLine());
            mark2 = int.Parse(Console.ReadLine());
            sum = mark1 + mark2;
            Console.WriteLine("Enter marks of 2 subjects for AVERAGE");
            mark1 = int.Parse(Console.ReadLine());
            mark2 = int.Parse(Console.ReadLine());
            average = mark1 / mark2;
        }
    }

    class D : C
    {
        public void Display()
        {
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Age is " + age);
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Average is " + average);
        }
    }

    internal class Program : D
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Read();
            obj.Mark();
            obj.Print();
            obj.Display();


            Console.ReadLine();

        }
    }
}
