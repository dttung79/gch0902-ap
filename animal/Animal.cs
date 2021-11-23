using System;
using System.Collections.Generic;

namespace animal
{
    public class Animal
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        public Animal()
        {
            name = "No animal name";
            age = 0;
            System.Console.WriteLine("Default Animal constructor....");
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            System.Console.WriteLine("Parameter Animal constructor.....");
        }


        public void ShowInfo() 
        {
            System.Console.WriteLine("Animal name: " + name);
            System.Console.WriteLine("Animal age: " + age);
        }
    }
}