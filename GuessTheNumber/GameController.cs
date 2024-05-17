namespace GuessTheNumber
{
    public class GameController
    {
        private GameModel _model;
        private GameView _view;

        public GameController(GameModel model, GameView view)
        {
            _model = model;
            _view = view;
        }

        public void Run()
        {
            _view.DisplayWelcomeMessage();

            bool guessedCorrectly = false;
            while (!guessedCorrectly)
            {
                int guess = _view.GetGuess();
                guessedCorrectly = _model.MakeGuess(guess, out string message);
                _view.DisplayMessage(message);
            }

            _view.DisplayThankYouMessage();
        }
    }
}
