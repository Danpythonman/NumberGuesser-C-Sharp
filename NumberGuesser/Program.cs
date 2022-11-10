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

                Console.WriteLine("A random number between 1 and 10 has been generated");

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
                        Console.WriteLine("Incorrect input. Please enter an integer.");
                        Console.WriteLine("Guess again: ");
                    }
                }

                if (guess == randomNumber)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong! The correct number was {0}", randomNumber);
                }

                Console.WriteLine("Would you like to play again? [y/n]");

                input = Console.ReadLine().ToLower();

                if (input != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}