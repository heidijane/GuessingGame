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

            while (guessesGiven < 4)
            {
                Console.WriteLine($"Guess the secret number! Your guess ({guessesGiven + 1})");

                string userGuess = Console.ReadLine();
                int parsedUserGuess = Int32.Parse(userGuess); //int and Int32 are the same method

                if (parsedUserGuess == secretNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    break; //breaks out of the loop
                }
                else
                {
                    Console.WriteLine("Sorry, that was incorrect.");
                }

                guessesGiven++;
            }

        }
    }
}