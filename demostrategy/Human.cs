using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demostrategy
{
    public class Human
    {
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }

        public int ChooseNumber(int low, int high) 
        {
            bool valid = false;
            int number = 0;
            while (!valid)
            {
                System.Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                valid = number >= low && number <= high;
                if (!valid) System.Console.WriteLine("Invalid number. Try again!");
            }
            return number;
        }
    }
}