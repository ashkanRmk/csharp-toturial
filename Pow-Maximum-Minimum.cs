using System;
using System.Linq;

namespace my_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter two number to power it:");
            Console.WriteLine("First number:");
            var x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second number:");
            var y = Convert.ToDouble(Console.ReadLine());

            var power = Pow(x, y);
            Console.WriteLine($"{x} power {y}: {power}");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Enter 5 numbers:");
            var myNumbers = new double[5];
            for (int i = 0; i < myNumbers.Length; i++)
            {
                myNumbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            var maximum = FindMaximum(myNumbers);
            var minimum = FindMinimum(myNumbers);

            Console.WriteLine($"Maximum number is: {maximum}");
            Console.WriteLine($"Minimum number is: {minimum}");
        }

        static double Pow(double x, double y)
        {
            double result = x;
            for (int i = 0; i < y - 1; i++)
            {
                result *= x;
            }
            return result;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double FindMaximum(double[] numbers)
        {
            double max = numbers[0];
            foreach (var number in numbers)
            {
                if (max < number)
                {
                    max = number;
                }
            }
            return max;
        }

        static double FindMinimum(double[] numbers)
        {
            double min = numbers[0];
            foreach (var number in numbers)
            {
                if (min > number)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
