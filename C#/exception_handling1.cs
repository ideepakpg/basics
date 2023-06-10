using System;

namespace exception_handling1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ar = { 5, 7, 3, 8, 3, 6, };

            try
            {
                Console.WriteLine($"Value is {ar[3]}");
            }

            catch
            {
                Console.WriteLine("Error Occured");
            }

            finally
            {
                Console.WriteLine("Finally program executed");
            }


            Console.ReadLine();

        }
    }
}
