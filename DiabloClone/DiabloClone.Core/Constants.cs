using DiabloClone.Core.Models;
using System.Collections.Generic;

namespace DiabloClone.Core
{
    public static class Constants
    {
        public const int DefaultAttackRating = 5;
        public const int DefaultDefenseRating = 3;

        public static readonly Dictionary<EnemyType, (int AttackRating, int DefenseRating)> DefaultEnemyRatings = new Dictionary<EnemyType, (int AttackRating, int DefenseRating)>
        {
            { EnemyType.Goblin, (5, 3) },
            { EnemyType.Orc, (6, 2) },
            { EnemyType.Wolf, (4, 4) }
        };
    }
}
