using System;

namespace output_parameter
{
    internal class Program
    {
        public int Sum(int a, out int b)
        {
            a = a + 10;
            b = a + 10;
            return a;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            int a = 10, b, c;
            c = obj.Sum(a, out b);
            Console.WriteLine("The value of a ={0} and b={1}", c, b);

            Console.ReadLine();
        }
    }
}
