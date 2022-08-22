using System;

namespace MyConsoleApp
{
    class Program
    {
        /*
        Sample exec command:
        dotnet run bmi --height 1.75 --weight 75
        dotnet run bmi --weight 75 --height 1.75
        */
        static void Main(string[] args)
        {
            Validations(args);
            Execute(args);
        }

        static void Execute(string[] args)
        {
            var firstSwitch = args[1];
            var firstArg = args[2];

            var secondSwitch = args[3];
            var secondArg = args[4];

            double height = 0;
            double weight = 0;
            switch (firstSwitch)
            {
                case "--height":
                    height = Convert.ToDouble(firstArg);
                    weight = Convert.ToDouble(secondArg);
                    CalculateBmi(height, weight);
                    break;
                case "--weight":
                    weight = Convert.ToDouble(firstArg);
                    height = Convert.ToDouble(secondArg);
                    CalculateBmi(height, weight);
                    break;
                default:
                    BadCommand();
                    break;
            }
        }

        static void Validations(string[] args)
        {
            if (args.Length == 0 || args[0] != "bmi")
            {
                BadCommand();
                Environment.Exit(0);
            }
            else if (args[1] == "--helps")
            {
                ShowHelp();
                Environment.Exit(0);
            }
            else if (args[1] == "--version")
            {
                ShowCurrentVersion();
                Environment.Exit(0);
            }
        }

        static void CalculateBmi(double height, double weight)
        {
            Console.WriteLine("\nYour BMI Score is:");
            var bmi = Math.Round(weight / (height * height));
            var status = "";
            if (bmi <= 18.4)
            {
                status = "Underweight";
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                status = "Normal";
            }
            else if (bmi > 25 && bmi < 39.9)
            {
                status = "Overweight";
            }
            else if (bmi >= 40)
            {
                status = "Obese";
            }
            Console.WriteLine(bmi);
            Console.WriteLine($"Your Status is: {status}");
        }

        static void ShowHelp()
        {
            Console.WriteLine("\nUse these switch to run program:");
            Console.WriteLine("--height\tYour height (centimeters)");
            Console.WriteLine("--weight\tYour weight (kilograms)");
            Console.WriteLine("--version\tShow current version");
            Console.WriteLine("--helps\t\tShow command list");
        }

        static void BadCommand()
        {
            Console.WriteLine("\nInvalid command :(");
            Console.WriteLine("Use --helps switch to show help");
        }

        static void ShowCurrentVersion()
        {
            Console.WriteLine("\nCurrent version is: 1.0");
        }
    }
}
