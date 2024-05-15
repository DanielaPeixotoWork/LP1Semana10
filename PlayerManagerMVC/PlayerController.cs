using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class PlayerController
    {
        private readonly List<Player> playerList;
        private readonly ConsoleView view;

        public PlayerController(ConsoleView view)
        {
            this.view = view;
            playerList = new List<Player>
            {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }

        public void Run()
        {
            string option;
            do
            {
                view.ShowMenu();
                option = view.GetInput("");

                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        view.ListPlayers(playerList);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        view.DisplayMessage("Bye!");
                        break;
                    case "5":
                        ListPlayersByName(true); // Ascending
                        break;
                    case "6":
                        ListPlayersByName(false); // Descending
                        break;
                    default:
                        view.DisplayMessage("\n>>> Unknown option! <<<\n");
                        break;
                }

                if (option != "4")
                {
                    view.DisplayMessage("\nPress any key to continue...");
                    Console.ReadKey(true);
                    Console.WriteLine("\n");
                }

            } while (option != "4");
        }

        private void InsertPlayer()
        {
            string name = view.GetInput("Enter player name: ");
            int score;
            while (!int.TryParse(view.GetInput("Enter player score: "), out score))
            {
                view.DisplayMessage("Invalid score. Please enter a valid integer.");
            }

            playerList.Add(new Player(name, score));
            view.DisplayMessage("Player added successfully.");
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            int minScore;
            while (!int.TryParse(view.GetInput("Enter the minimum score: "), out minScore))
            {
                view.DisplayMessage("Invalid score. Please enter a valid integer.");
            }

            var filteredPlayers = GetPlayersWithScoreGreaterThan(minScore);
            view.ListPlayers(filteredPlayers);
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (var player in playerList)
            {
                if (player.Score > minScore)
                {
                    yield return player;
                }
            }
        }

        private void ListPlayersByName(bool ascending)
        {
            var sortedPlayers = new List<Player>(playerList);
            sortedPlayers.Sort(new CompareByName(ascending));
            view.ListPlayers(sortedPlayers);
        }
    }
}
