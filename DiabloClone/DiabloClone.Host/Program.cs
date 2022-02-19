using DiabloClone.Core;
using DiabloClone.Core.Models;
using System.Runtime.InteropServices;

namespace DiabloClone.Host 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name = null;

            while (name == null)
            {
                Console.Write("Enter player's name: ");
                name = Console.ReadLine();
            }

            var player = new Player();
            player.Name = name;
            Console.WriteLine($"New player {name} created");

            var gameEngine = new GameEngine(player);

            string? action;

            do
            {
                DisplayMenu();
                action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        gameEngine.Fight();
                        break;
                    default:
                        Console.WriteLine($"Unknown action {action}");
                        break;
                }

            } while (action != "q");
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("[1] - Fight!");
            Console.WriteLine("[2] - Show inventory");
            Console.WriteLine("[q] - Quit game");
        }
    }
}
