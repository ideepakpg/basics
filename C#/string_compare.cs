﻿using System;

namespace string_compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "Csharp";
            string s4 = "mello";

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));
            Console.WriteLine(string.Compare(s3, s4));
            Console.WriteLine(string.Compare(s4, s1));

            Console.ReadLine();

        }
    }
}
