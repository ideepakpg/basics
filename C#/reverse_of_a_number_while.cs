using System;

namespace reverse_of_a_number_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rem, rev = 0;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse number is " + rev);
            Console.ReadLine();
        }
    }
}
