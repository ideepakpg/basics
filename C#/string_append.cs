using System;
using System.Text;

namespace string_append
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");
            sb.AppendLine("Hello C#");
            sb.AppendLine("This is a new line");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
