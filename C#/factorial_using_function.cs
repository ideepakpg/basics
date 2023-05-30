using System;

namespace factorial_using_function
{

    internal class Program
    {
        public int Factorial()
        {
            int i, n, f = 1;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }

            Console.WriteLine("Factorial is : " + f);
            return f;
        }

        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Factorial();

            Console.ReadLine();

        }
    }
}
