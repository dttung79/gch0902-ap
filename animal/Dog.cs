using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animal
{
    public class Dog : Animal
    {
        private int loyalty;
        public Dog()
        {
            Name = "No dog name";
            System.Console.WriteLine("Default Dog constructor....");
            loyalty = 8;
        }

        public Dog(string name, int age) : base(name, age)
        {
            System.Console.WriteLine("Parameter Dog constructor....");
            loyalty = 8;
            // Name = name;
            // Age = age;
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Loyaty: " + loyalty);
        }
    }
}