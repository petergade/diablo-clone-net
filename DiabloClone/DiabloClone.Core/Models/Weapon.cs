namespace DiabloClone.Core.Models
{
    public abstract class Weapon
    {
        public int Attack { get; set; }

        public WeaponType WeaponType { get; set; }
    }
}
