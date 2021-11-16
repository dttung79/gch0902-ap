using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceProject 
{
    public class Dice
    {
        private int number; // can access only in Dice => protect data inside
        
        // properties
        public int Number
        {
            get { return number; }
            set 
            { 
                if (value > 0 && value < 7)
                    number = value; 
                else 
                {
                    Console.WriteLine("Invalid dice number!");
                    number = 1;
                }
            }
        }

        // default constructor
        public Dice()
        {
            number = 1;
        }
        // parameter constructor
        public Dice(int number)
        {
            //this.number = number;
            Number = number;
        }

        public void Roll()
        {
            Random rd = new Random();
            number = rd.Next(1, 6);
        }
    }
}