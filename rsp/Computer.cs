using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rsp
{
    public class Computer : Player
    {
        public Computer()
        {
            Name = "Computer";
            Points = 0;
        }

        public override int Pick()
        {
            Random rd = new Random();
            int choice = rd.Next(3) + 1; // random 1 or 2 or 3
            return choice;
        }
    }
}