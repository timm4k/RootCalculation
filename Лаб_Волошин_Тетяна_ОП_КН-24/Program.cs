using System;

class Program
{
    static void Main()
    {
        Console.Write("Input x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        double expression = 0.1 * x1 * Math.Sin(x2) * Math.Pow(Math.Cos(x1), 2) + 55 * x1 * x2;

        if (expression < 0)
        {
            Console.WriteLine("The result under the root is negative. You cannot take the root of a negative num.");
        }
        else
        {
            double y = Math.Pow(expression, 1.0 / 5.0);

            Console.WriteLine($"x1: {x1}");
            Console.WriteLine($"x2: {x2}");
            Console.WriteLine($"Result y: {y}");
        }
    }
}
