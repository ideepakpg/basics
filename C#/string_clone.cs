using System;

namespace string_clone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = (string)s1.Clone();

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadLine();

        }
    }
}
