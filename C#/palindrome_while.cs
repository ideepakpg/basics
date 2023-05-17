using System;

namespace palindrome_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, rem, rev = 0, temp;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("Given number is a palindrome");
            }
            else
            {
                Console.WriteLine("Given number is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
