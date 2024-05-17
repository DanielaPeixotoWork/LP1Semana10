namespace GuessTheNumber
{
    public class Program
    {
        public static void Main()
        {
            GameModel model = new GameModel();
            GameView view = new GameView();
            GameController controller = new GameController(model, view);

            controller.Run();
        }
    }
}
