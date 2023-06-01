using System;

namespace interface_aka_multiple_Inheritance
{
    interface A
    {
        void Sum(int a, int b);
    }

    interface B
    {
        int Product(int a, int b);
    }
    internal class Program : A, B
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum is {0} ", a + b);
        }

        public int Product(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Sum(30, 20);
            obj.Product(25, 4);
            int p = obj.Product(25, 4);
            Console.WriteLine("Product is " + p);

            Console.ReadLine();

        }
    }
}
