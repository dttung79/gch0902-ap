using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demofactory
{
    public abstract class Armor
    {
        public int Defense { get; set; }
        public abstract int Block(Weapon w);
    }

    public class IronArmor : Armor
    {
        public IronArmor()
        {
            Defense = 4;
        }

        public override int Block(Weapon w)
        {
            System.Console.WriteLine("XXX");
            return w.Damage - Defense;
        }
    }

    public class LeatherArmor : Armor
    {
        public LeatherArmor()
        {
            Defense = 2;
        }
        public override int Block(Weapon w)
        {
            System.Console.WriteLine("//");
            return w.Damage - Defense;
        }
    }
}