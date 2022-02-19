using DiabloClone.Core.Services;
using System;

namespace DiabloClone.Core.Models
{
    public class GameEngine
    {
        private static readonly Random Random = new ();

        private static readonly EnemyGenerator EnemyGenerator = new ();

        public Player Player { get; set; }

        public GameEngine(Player player)
        {
            Player = player;
        }

        public void StartGame()
        {

        }

        private void NextTurn(Character attacker, Character defender)
        {
            defender.Health -= Random.Next(1, 5);
        }

        public void Fight()
        {
            var enemy = EnemyGenerator.GenerateRandomEnemy(Random, Player.Level);
            Character attacker = Random.NextDouble() > 0.5 ? Player : enemy;
            Character defender = ReferenceEquals(attacker, Player) ? enemy : Player;

            while (Player.Health > 0 && enemy.Health > 0)
            {
                NextTurn(attacker, defender);
                Console.WriteLine($"After turn - attacker: {attacker}, defender: {defender}");
                Swap();
            }

            Console.WriteLine(Player.Health == 0 ? $"Player {Player.Name} is dead" : "Enemy is dead");

            void Swap()
            {
                attacker = ReferenceEquals(attacker, Player) ? enemy : Player;
                defender = ReferenceEquals(defender, Player) ? enemy : Player;
            }
        }
    }
}
