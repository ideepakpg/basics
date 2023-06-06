namespace function_overloading2
{
    internal class Program
    {

        public string Function(string name)             // string value
        {
            return name;
        }

        public int Function(int mark1, int mark2)       // integer value
        {
            return mark1 + mark2;
        }

        public double Function(double d1, double d2)    // double value
        {
            return d1 + d2;
        }

        public float Function(float f1, float f2)       // float value
        {
            return f1 + f2;
        }


        static void Main(string[] args)
        {

            Program obj = new Program();


            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            obj.Function(name);
            Console.WriteLine("Your name is " + name);

            Console.WriteLine("Enter two marks");
            int mark1 = int.Parse(Console.ReadLine());
            int mark2 = int.Parse(Console.ReadLine());
            obj.Function(mark1, mark2);
            Console.WriteLine($"Your total mark is {mark1 + mark2}");

            Console.WriteLine("Enter two values");
            double d1 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            obj.Function(d1, d2);
            Console.WriteLine($"Sum is {d1 + d2}");

            Console.WriteLine("Enter two values");
            float f1 = float.Parse(Console.ReadLine());
            float f2 = float.Parse(Console.ReadLine());
            obj.Function(f1, f2);
            Console.WriteLine($"Average is {f1 / f2}");

            Console.ReadLine();

        }
    }
}
