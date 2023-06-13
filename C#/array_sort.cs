using System;
using System.Collections;

namespace array_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            ArrayList item = new ArrayList();
            item.Add("item 4");
            item.Add("item 1");
            item.Add("item 5");
            item.Add("item 2");
            item.Add("item 3");
            Console.WriteLine("Show added items");
            for (i = 0; i <= item.Count - 1; i++)
            {
                Console.WriteLine(item[i].ToString());
            }

            item.Insert(3, "item 6");
            Console.WriteLine("Insert an item");
            for (i = 0; i <= item.Count - 1; i++)
            {
                Console.WriteLine(item[i].ToString());
            }

            item.Sort();
            Console.WriteLine("Sorted array list");
            for (i = 0; i <= item.Count - 1; i++)
            {
                Console.WriteLine(item[i].ToString());
            }

            item.Remove("item 1");
            Console.WriteLine("Remove an item");
            for (i = 0; i <= item.Count - 1; i++)
            {
                Console.WriteLine(item[i].ToString());
            }

            item.RemoveAt(3);
            Console.WriteLine("Remove 3rd item");
            for (i = 0; i <= item.Count - 1; i++)
            {
                Console.WriteLine(item[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
