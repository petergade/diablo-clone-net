using System;

namespace DiabloClone.Core.Models;

public abstract class Character
{
    public int Level { get; set; } = 1;

    public int Health { get; set; } = 100;

    public virtual int AttackRating { get; set; }

    public virtual int DefenseRating { get; set; }

    public override string ToString()
    {
        return $"Level = {Level}, Health = {Health}, Type = {GetType().Name}";
    }
}
