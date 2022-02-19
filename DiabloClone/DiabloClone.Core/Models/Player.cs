using System.Collections.Generic;

namespace DiabloClone.Core.Models
{
    public class Player : Character
    {
        public string Name { get; set; }

        public long Experience { get; set; }

        //public PlayerAttributes PlayerAttributes { get; set; }

        public override int AttackRating { get; set; } = Constants.DefaultAttackRating;

        public override int DefenseRating { get; set; } = Constants.DefaultDefenseRating;

        public List<InventoryItem> Inventory { get; set; } = new ();
    }
}
