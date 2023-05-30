using System;

namespace return_type_function
{
    internal class Program
    {

        public int Sum()
        {
            int a = 5;
            int b = 5;
            Console.WriteLine("Sum is {0}", a + b);       //or use line 20
            return a + b;
        }

        static void Main(string[] args)
        {

            Program obj = new Program();
            Console.WriteLine(obj.Sum());

            Console.ReadLine();

        }
    }
}
