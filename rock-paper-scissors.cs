using System;
using System.Linq;

namespace my_console_app
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            bool playAgain = true;
            string player, computer;

            while (playAgain)
            {
                player = SetPlayerRound();
                computer = SetComputerRound(random);

                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                WinDetector(player, computer);

                playAgain = ConfirmPlayAgain();
            }

            Console.WriteLine("Thanks for playing!");
        }

        static bool ConfirmPlayAgain()
        {
            Console.Write("Would you like to play again (Y/N): ");
            var answer = Console.ReadLine();
            return answer.ToUpper() == "Y";
        }

        static string SetPlayerRound()
        {
            string player = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }

            return player;
        }

        static string SetComputerRound(Random random)
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
                case 3:
                    return "SCISSORS";
                default:
                    return "";
            }
        }

        static void WinDetector(string player, string computer)
        {
            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }
        }
    }
}
