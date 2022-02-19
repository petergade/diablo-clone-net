using DiabloClone.Core.Models;
using System;

namespace DiabloClone.Core.Services
{
    public class EnemyGenerator
    {
        public Enemy GenerateRandomEnemy(Random random, int playerLevel)
        {
            var values = Enum.GetValues(typeof(EnemyType));
            var enemyType = (EnemyType)values.GetValue(random.Next(values.Length))!;

            var enemy = new Enemy
            {
                Type = enemyType,
                AttackRating = Constants.DefaultEnemyRatings[enemyType].AttackRating,
                DefenseRating = Constants.DefaultEnemyRatings[enemyType].DefenseRating,
                Level = playerLevel
            };

            return enemy;
        }
    }
}
