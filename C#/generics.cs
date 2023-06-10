using System;

namespace generics
{
    public class Gen<x, y>
    {
        public x a;
        public y b;
        public Gen(x i, y j)
        {
            a = i;
            b = j;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, m;
            Console.WriteLine("Enter two numbers");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            Gen<int, int> obj = new Gen<int, int>(n, m);     //Gen<string, string> obj = new Gen<string, string>(name1, name2);

            Console.WriteLine($"Sum is {obj.a + obj.b}");    //Console.WriteLine($"Name is {obj.a} {obj.b}");


            Console.ReadLine();

        }
    }
}
