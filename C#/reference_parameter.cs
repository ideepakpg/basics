using System;

namespace reference_parameter
{
    internal class Program
    {
        public void Sum(ref int x)
        {
            x = x + 10;
            Console.WriteLine("Sum = " + x);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            int x = 10;
            obj.Sum(ref x);
            Console.WriteLine("Value of x after calling = " + x);

            Console.ReadLine();

        }
    }
}
