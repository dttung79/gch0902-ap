using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rsp
{
    public class Human : Player
    {
        public Human()
        {
            Name = "Human";
            Points = 0;
        }

        public Human(string name) : base(name)
        {
            Points = 0;
        }

        public override int Pick()
        {
            System.Console.WriteLine("Pick one:");
            System.Console.WriteLine("1. Rock");
            System.Console.WriteLine("2. Paper");
            System.Console.WriteLine("3. Scissor");
            System.Console.Write("Your pick: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}