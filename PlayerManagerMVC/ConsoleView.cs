using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class ConsoleView
    {
        public void ShowMenu()
        {
            Console.WriteLine("Player Manager");
            Console.WriteLine("1. Insert Player");
            Console.WriteLine("2. List All Players");
            Console.WriteLine("3. List Players with Score Greater Than");
            Console.WriteLine("4. Quit");
            Console.WriteLine("5. List Players by Name (Ascending)");
            Console.WriteLine("6. List Players by Name (Descending)");
            Console.Write("Enter option: ");
        }

        public void ListPlayers(IEnumerable<Player> players)
        {
            Console.WriteLine("Player List:");
            foreach (var player in players)
            {
                Console.WriteLine($"Name: {player.Name}, Score: {player.Score}");
            }
        }

        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
