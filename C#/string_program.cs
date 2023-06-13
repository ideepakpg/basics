using System;

namespace string_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "    Good Morning    ";
            string b = "hello friends";
            string c = a.Clone().ToString();
            Console.WriteLine(c);


            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.StartsWith("s"));
            Console.WriteLine(b.EndsWith("s"));
            Console.WriteLine(a.Contains("r"));
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.IndexOf("0"));
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine(b.Length);
            Console.WriteLine(a.Trim());
            Console.WriteLine(a.TrimEnd());
            Console.WriteLine(a.Insert(0, "hai"));
            Console.WriteLine(a.LastIndexOf("o"));
            Console.WriteLine(a.Remove(8));
            Console.WriteLine(b.Replace("l", "m"));
            Console.WriteLine(b.Substring(2, 6));


            Console.ReadLine();
        }
    }
}
