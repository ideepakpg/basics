using System;

namespace no_return_type_function
{
    internal class Program
    {
        public void MyFunction()
        {
            Console.WriteLine("Some Message");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.MyFunction();

            Console.ReadLine();

        }
    }
}
