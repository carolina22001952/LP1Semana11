using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {
        private Model model;
        private View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void Play()
        {
            view.PrintWelcome();
            model.GenerateNumber();

            bool guessedCorrectly = false;

            while(!guessedCorrectly)
            {
                view.PrintNumberGuess();
                int guess = Convert.ToInt32(Console.ReadLine());

                guessedCorrectly = model.MakeGuess(guess);

                if(guessedCorrectly)
                {
                    int attempts = model.NumberOfAttempts();
                    view.PrintWinMessage(attempts);
                }
            }
            
            view.PrintGoodBye();
        }
    }
}