using System;

namespace string_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, x = null;
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            int l = s.Length;

            for (int i = l - 1; i >= 0; i--)
            {
                x = x + s[i];
            }

            if (s == x)
            {
                Console.WriteLine("String is Palindrome");  /*malayalam*/
            }

            else
            {
                Console.WriteLine("String is not a Palindrome");  /*hello*/
            }

            Console.ReadLine();
        }
    }
}
