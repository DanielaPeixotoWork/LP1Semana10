namespace GuessTheNumber
{
    public class GameModel
    {
        private Random _random = new Random();
        public int TargetNumber { get; private set; }
        public int Attempts { get; private set; }

        public GameModel()
        {
            TargetNumber = _random.Next(1, 101);
            Attempts = 0;
        }

        public bool MakeGuess(int guess, out string message)
        {
            Attempts++;
            if (guess == TargetNumber)
            {
                message = $"Congratulations! You guessed the number correctly in {Attempts} attempts.";
                return true;
            }
            else if (guess < TargetNumber)
            {
                message = "Too low! Try again.";
            }
            else
            {
                message = "Too high! Try again.";
            }
            return false;
        }
    }
}
