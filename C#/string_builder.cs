using System;
using System.Text;   /*must include in string builder*/

namespace string_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");

            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }

            Console.ReadLine();

        }
    }
}
