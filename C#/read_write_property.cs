using System;

namespace read_write_property
{
    class MyClass                     // working of get and set properties
    {
        private int x;
        public int pname
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            MyClass obj = new MyClass();
            obj.pname = 100;
            Console.WriteLine($"Value of x is {obj.pname}");

            Console.ReadLine();


        }
    }
}
