using System;

namespace demofactory
{
    public abstract class Weapon
    {
        public int Damage { get; set; }

        public abstract void Attack(Character other);
    }

    public class Bow : Weapon
    {
        public Bow()
        {
            Damage = 10;
        }
        public override void Attack(Character other)
        {
            System.Console.WriteLine(">---------|>");
            System.Console.WriteLine(">---------|>");
            System.Console.WriteLine(">---------|>");
            
            // affect hp of other
            int finalDamage = other.ARM.Block(this);
            other.HP -= finalDamage;
            System.Console.WriteLine("HP of " + other.Name + " after hit: " + other.HP);
        }
    }

    public class Sword : Weapon
    {
        public Sword()
        {
            Damage = 5;
        }
        public override void Attack(Character other)
        {
            System.Console.WriteLine("[=))============\\");
            // affect hp of other
            int finalDamage = other.ARM.Block(this);
            other.HP -= finalDamage;
            System.Console.WriteLine("HP of " + other.Name + " after hit: " + other.HP);
        }
    }
}