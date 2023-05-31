
//Error in program

using System;

namespace parameter_array
{
    internal class Program
    {
        public void Array(int[] ar)
        {
            Console.WriteLine("Array elements are ");

            foreach (int in ar)
            {
                Console.Write(" " + item);
            }
        }

        static void Main(string[] args)
        {
            int n, item;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Read array elements");

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Program obj = new Program();
            obj.Array(a);

            Console.ReadLine();
        }
    }
}
