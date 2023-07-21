namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("WELCOME");
                Console.WriteLine("Enter a number to execute :");
                Console.WriteLine("1) Convert number to alphabet");
                Console.WriteLine("2) Convert number to day of week");
                Console.WriteLine("3) Exit");
                Console.Write("--> ");
                var menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter a number between 1 to 10 :");
                        var digit = Convert.ToInt32(Console.ReadLine());

                        var result = "";

                        switch (digit)
                        {
                            case 0:
                                result = "Zero";
                                break;
                            case 1:
                                result = "One";
                                break;
                            case 2:
                                result = "Two";
                                break;
                            case 3:
                                result = "Three";
                                break;
                            case 4:
                                result = "Four";
                                break;
                            case 5:
                                result = "Five";
                                break;
                            case 6:
                                result = "Six";
                                break;
                            case 7:
                                result = "Seven";
                                break;
                            case 8:
                                result = "Eight";
                                break;
                            case 9:
                                result = "Nine";
                                break;
                            case 10:
                                result = "Ten";
                                break;
                            default:
                                Console.WriteLine("You entered out of range!");
                                break;
                        }

                        if (!string.IsNullOrEmpty(result))
                            Console.WriteLine($"--> Result: {result}");

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter a number between 1 to 7 for days of the week:");
                        var numberOfDay = Console.ReadLine();
                        var dayOfWeek = "";
                        switch (numberOfDay)
                        {
                            case "1":
                                dayOfWeek = "Saturday";
                                break;
                            case "2":
                                dayOfWeek = "Sunday";
                                break;
                            case "3":
                                dayOfWeek = "Monday";
                                break;
                            case "4":
                                dayOfWeek = "Tuesday";
                                break;
                            case "5":
                                dayOfWeek = "Wednesday";
                                break;
                            case "6":
                                dayOfWeek = "Thursday";
                                break;
                            case "7":
                                dayOfWeek = "Friday";
                                break;

                            default:
                                Console.WriteLine("You entered out of range!");
                                break;
                        }

                        if (!string.IsNullOrEmpty(dayOfWeek))
                            Console.WriteLine($"--> Today is {dayOfWeek} :)");

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Good Bye :)");
                        exit = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("You entered wrong item.\n Try again.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

