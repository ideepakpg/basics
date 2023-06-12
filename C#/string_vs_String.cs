using System;

namespace string_vs_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string s1 = "Hello";*/  /*creating string using string keyword*/

            /*String s2 = "Welcome";*/  /*creating string using String class*/


            string s1 = "Hello";
            char[] ch = { 'C', 'S', 'H', 'A', 'R', 'P' };
            String s2 = new string(ch);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadLine();

        }
    }
}
