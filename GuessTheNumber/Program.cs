using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            View view = new View();
            Model model = new Model(view);
            Controller controller = new Controller(model, view);
            controller.Play();

        }
    }
}