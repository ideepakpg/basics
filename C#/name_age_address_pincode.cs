using System;

namespace name_age_address_pincode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);

            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            Console.WriteLine("Enter your address");
            String address = Console.ReadLine();
            Console.WriteLine("Your address is " + address);

            Console.WriteLine("Enter your pincode");
            int pincode = int.Parse(Console.ReadLine());
            Console.WriteLine("Your pincode is " + pincode);

            Console.ReadLine();
        }
    }
}
