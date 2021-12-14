using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demofactory
{
    public abstract class Character
    {
        public int Damage { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }

        public Weapon WEP { get; set; }
        public Armor ARM { get; set; }

        public void Build()
        {
            System.Console.Write("Enter name: ");
            Name = Console.ReadLine();
            WEP = CreateWeapon();
            ARM = CreateArmor();
        }

        protected abstract Armor CreateArmor();

        protected abstract Weapon CreateWeapon();

        public void Attack(Character other) 
        {
            System.Console.WriteLine(Name + " attacts " + other.Name);
            WEP.Attack(other);
        }
    }

    public class Archer : Character
    {
        public Archer() 
        {
            Damage = 10;
            HP = 100;
        }
        protected override Armor CreateArmor()
        {
            return new LeatherArmor();
        }

        protected override Weapon CreateWeapon()
        {
            return new Bow();
        }
    }

    public class Warrior : Character
    {
        public Warrior()
        {
            Damage = 20;
            HP = 250;
        }
        protected override Armor CreateArmor()
        {
            return new IronArmor();
        }

        protected override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}