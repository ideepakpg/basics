using System;

namespace single_inheritance2
{
    class SingleInheritance
    {
        public int a, b, result;
        public void Read()
        {
            Console.WriteLine("Enter 2 numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            result = a + b;
        }
    }
    internal class Program : SingleInheritance
    {
        public void Sum()
        {
            Console.WriteLine("Sum is " + result);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Read();
            obj.Sum();

            Console.ReadLine();
            +
        }
    }
}
