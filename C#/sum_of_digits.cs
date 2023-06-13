using System;

namespace sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rem, sum = 0;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());

            /*n = 123,rem,sum = 0*/
            while (n > 0)          /* while (123 > 0)        | 12>0    | 1>0    | .1>0*/
            {                                        /*      |         |        | FALSE*/
                rem = n % 10;       /*rem = 123%10=3         | 12%10=2 | 1%10=1 |*/
                sum = sum + rem;    /*sum = sum +rem = 0+3=3 | 3+2=5   | 5+1=6  |*/
                n = n / 10;        /* n = 123/10=12          |12/10=1  | 1/10=.1|*/
            }

            Console.WriteLine($"Sum of digits = {sum}");

            Console.ReadLine();
        }
    }
}
