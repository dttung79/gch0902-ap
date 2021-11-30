using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demointerface
{
    public class Animal
    {
        public string Name { get; set; }
        public Animal()
        {
            Name = "No name";
        }
        public Animal(string name)
        {
            Name = name;
        }
    }
}