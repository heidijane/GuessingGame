using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //Random is a data type! creates a new Ranom class
            int secretNumber = rand.Next(1, 101); //gets you a non-negative random integer between 1 and 100

            int guessesGiven = 0;

            Console.WriteLine("Welcome to...");
            Console.WriteLine("~~*The Guessing Game*~~");
            Console.WriteLine("Please input your difficulty (Easy, Medium, or Hard)");

            int maxTries = 0;
            bool hasUserChosenDifficulty = false;

            while (hasUserChosenDifficulty == false)
            {
                string userDifficulty = Console.ReadLine();

                if (userDifficulty == "Easy")
                {
                    maxTries = 8;
                    break;
                }
                else if (userDifficulty == "Medium")
                {
                    maxTries = 6;
                    break;
                }
                else if (userDifficulty == "Hard")
                {
                    maxTries = 4;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid difficulty given, please input Easy, Medium, or Hard.");
                    continue;
                }
            }

            Console.WriteLine();

            while (guessesGiven < maxTries)
            {
                Console.WriteLine($"Guess the secret number! Your guess ({guessesGiven + 1})");

                string userGuess = Console.ReadLine();
                int parsedUserGuess = Int32.Parse(userGuess); //int and Int32 are the same method

                if (parsedUserGuess == secretNumber)
                {
                    Console.WriteLine("You guessed correctly! YOU WIN!");
                    break; //breaks out of the loop
                }
                else if (parsedUserGuess < secretNumber)
                {
                    Console.WriteLine("Number too low.");
                }
                else
                {

                    Console.WriteLine("Number too high.");
                }

                guessesGiven++;

                if (guessesGiven != maxTries)
                {
                    Console.WriteLine("Try again!");
                }
                else
                {
                    Console.WriteLine("Game Over.");
                }
                Console.WriteLine();
            }

        }
    }
}