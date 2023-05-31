using System;

namespace static_function
{
    internal class Program
    {

        public static void S_function()
        {
            Console.WriteLine("It is a Static function");
        }
        static void Main(string[] args)
        {

            S_function();

            Console.ReadLine();

        }
    }
}
