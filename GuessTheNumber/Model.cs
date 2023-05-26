using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Model
    {
        private Random random;
        private View view;
        private int targetNumber;
        private int attempts;

        public Model(View view)
        {
            this.view = view;
            random = new Random();
            attempts = 0;
        }

        public void GenerateNumber()
        {
            targetNumber = random.Next(1,101);
        }

        public bool MakeGuess(int guess)
        {
            attempts++;

            if (guess == targetNumber)
            {
                return true;
            }
            else if (guess < targetNumber)
            {
                view.PrintTooLow();
            }
            else
            {
                view.PrintTooHigh();
            }

            return false;
        }

        public int NumberOfAttempts()
        {
            return attempts;
        }
    }
}