using System;

namespace GuessTheNumber
{
    public class GameView
    {
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public int GetGuess()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayThankYouMessage()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}
