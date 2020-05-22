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
            bool cheaterMode = false;

            while (hasUserChosenDifficulty == false)
            {
                string userDifficulty = Console.ReadLine();

                if (userDifficulty == "Easy")
                {
                    maxTries = 8;
                    Console.WriteLine("Easy Mode: you get 8 guesses");
                    break;
                }
                else if (userDifficulty == "Medium")
                {
                    maxTries = 6;
                    Console.WriteLine("Medium Mode: you get 6 guesses");
                    break;
                }
                else if (userDifficulty == "Hard")
                {
                    maxTries = 4;
                    Console.WriteLine("Hard Mode: you get 4 guesses");
                    break;
                }
                else if (userDifficulty == "Cheater")
                {
                    Console.WriteLine("Cheater mode activated! You now have infinite guesses. ;P");
                    cheaterMode = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid difficulty given, please input Easy, Medium, or Hard.");
                    continue;
                }
            }

            Console.WriteLine();

            while (guessesGiven < maxTries || cheaterMode == true)
            {
                Console.WriteLine("Guess the secret number!");

                string userGuess = Console.ReadLine();
                int parsedUserGuess = Int32.Parse(userGuess); //int and Int32 are the same method

                if (parsedUserGuess == secretNumber)
                {
                    Console.WriteLine("You guessed correctly! YOU WIN!");
                    break; //breaks out of the loop
                }
                else if (parsedUserGuess > secretNumber)
                {
                    if ((parsedUserGuess - secretNumber) < 10)
                    {
                        Console.WriteLine($"Go a little lower.");
                    }
                    else
                    {
                        Console.WriteLine($"Go lower.");
                    }
                }
                else
                {
                    if ((secretNumber - parsedUserGuess) < 10)
                    {
                        Console.WriteLine($"Go a little higher.");
                    }
                    else
                    {
                        Console.WriteLine($"Go higher.");
                    }

                }

                guessesGiven++;

                if (cheaterMode != true)
                {
                    Console.WriteLine($"{maxTries - guessesGiven} {((maxTries - guessesGiven) == 1 ? "try" : "tries")} left");
                }

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