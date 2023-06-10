using System;

namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            Console.WriteLine("Enter two numbers");

            try
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Division is {num1 / num2}");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero . Please try again");
                Console.WriteLine($"Defined message : {ex}");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid number . Please try again");
                Console.WriteLine($"Defined message : {ex}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Defined message : {ex}");
            }

            finally
            {
                Console.WriteLine("Finally program executed");
            }


            Console.ReadLine();

        }
    }
}
