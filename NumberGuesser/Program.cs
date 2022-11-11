using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Guesser!");

            Random random = new Random();
            int randomNumber, guess;
            string input;

            while (true)
            {
                randomNumber = random.Next(1, 10);

                PrintGreeting();

                Console.WriteLine("Take a guess: ");

                while (true)
                {
                    input = Console.ReadLine();

                    if (int.TryParse(input, out guess))
                    {
                        break;
                    }
                    else
                    {
                        PrintIncorrectInputMessage();
                        Console.WriteLine("Guess again: ");
                    }
                }

                if (guess == randomNumber)
                {
                    PrintWinMessage();
                }
                else
                {
                    PrintLoseMessage(randomNumber);
                }

                PrintPlayAgainMessage();

                input = Console.ReadLine().ToLower();

                if (input != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

        static void PrintGreeting()
        {
            Console.Write("A random number between ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("1");

            Console.ResetColor();
            Console.Write(" and ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("10");

            Console.ResetColor();
            Console.Write(" has been generated\n");
        }

        static void PrintIncorrectInputMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect input. Please enter an integer.");
            Console.ResetColor();
        }

        static void PrintWinMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            Console.ResetColor();
        }

        static void PrintLoseMessage(int correctNumber)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Wrong! The correct number was ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0}\n", correctNumber);
            Console.ResetColor();
        }
        static void PrintPlayAgainMessage()
        {
            Console.Write("Would you like to play again? [");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("y");

            Console.ResetColor();
            Console.Write("/");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("y");

            Console.ResetColor();
            Console.Write("]\n");
        }
    }
}