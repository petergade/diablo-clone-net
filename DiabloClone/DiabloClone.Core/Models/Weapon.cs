namespace DiabloClone.Core.Models
{
    public abstract class Weapon : InventoryItem
    {
        public int Attack { get; set; }

        public WeaponType WeaponType { get; set; }
    }
}
