using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demointerface
{
    public class Dog : Animal, IMoveable
    {
        public void Move()
        {
            System.Console.WriteLine("Dog " + Name + " runs at 50km/h");
        }

        public Dog(string name) : base(name) {}
    }
}