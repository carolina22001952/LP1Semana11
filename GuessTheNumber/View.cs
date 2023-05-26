using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public void PrintNumberGuess()
        {
            Console.Write("Take a guess: ");
        }

        public void PrintWinMessage(int attempts)
        {
            Console.WriteLine(
                        "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void PrintTooLow()
        {
            Console.WriteLine("Too low! Try again.");
        }

        public void PrintTooHigh()
        {
            Console.WriteLine("Too high! Try again.");
        }

        public void PrintGoodBye()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}