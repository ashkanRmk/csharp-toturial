using System;
using System.Linq;

namespace my_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            do
            {
                Console.Clear();
                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                SetCalculatorOperators(calculator);

                calculator.PrintOptions();

                calculator.Operand = Console.ReadLine();

                try
                {
                    calculator.Process();
                    Console.WriteLine(calculator);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
        }

        private static void SetCalculatorOperators(Calculator calculator)
        {
            Console.Write("Enter number 1: ");
            calculator.FirstOperator = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            calculator.SecondOperator = Convert.ToDouble(Console.ReadLine());
        }

        public class Calculator
        {
            public double FirstOperator { get; set; }
            public double SecondOperator { get; set; }
            private double _result;
            private string _operand;

            public string Operand
            {
                set
                {
                    if (value == "*" ||
                        value == "-" ||
                        value == "+" ||
                        value == "/")
                    {
                        _operand = value;
                    }
                }
            }

            public void PrintOptions()
            {
                Console.WriteLine("Options: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");
            }

            public void Process()
            {
                switch (_operand)
                {
                    case "+":
                        _result = FirstOperator + SecondOperator;
                        break;
                    case "-":
                        _result = FirstOperator - SecondOperator;
                        break;
                    case "*":
                        _result = FirstOperator * SecondOperator;
                        break;
                    case "/":
                        _result = FirstOperator / SecondOperator;
                        break;
                    default:
                        throw new Exception("That was not a valid option");
                }
            }

            public override string ToString()
            {
                return $"Your result: {FirstOperator} {_operand} {SecondOperator} = {_result}";
            }
        }
    }
}
