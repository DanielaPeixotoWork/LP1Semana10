namespace PlayerManagerMVC
{
    public class Program
    {
        public static void Main()
        {
            ConsoleView view = new ConsoleView();
            PlayerController controller = new PlayerController(view);
            controller.Run();
        }
    }
}
