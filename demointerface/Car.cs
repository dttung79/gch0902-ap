using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demointerface
{
    public class Car : IMoveable
    {
        public void Move()
        {
            System.Console.WriteLine("Car go from one place to another.");
        }
    }
}