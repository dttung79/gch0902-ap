using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demointerface
{
    public class Bird : Animal, IMoveable
    {
        public void Move()
        {
            System.Console.WriteLine("Bird " + Name + " flies in the air!");
        }
        public Bird(string name) : base(name) {}
    }
}