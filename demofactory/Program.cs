using System;

namespace demofactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Character yasuo = new Archer();
            Character noobMaster = new Warrior();

            yasuo.Build();
            noobMaster.Build();

            yasuo.Attack(noobMaster);
            System.Console.WriteLine("-----------------");
            noobMaster.Attack(yasuo);

        }
    }
}
