using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demostrategy
{
    public abstract class Computer
    {
        public int OldNumber { get; set; }

        public string Name { get; set; }
        public int Low { get; set; }
        public int High { get; set; }

        public Computer(string name, int low, int high)
        {
            Name = name;
            OldNumber = 0;
            Low = low;
            High = high;
        }

        public abstract int GuessNumber(int lastGuess);
        public const int LESS_THAN = 1;
        public const int GREATER_THAN = 2;
        public const int FIRST_GUESS = 0;
    }

    public class RandomComputer : Computer
    {
        public RandomComputer(int low, int high) : base("RandomComputer", low, high)
        {}
        public override int GuessNumber(int lastGuess)
        {
            Random rd = new Random();
            return rd.Next(Low, High + 1);
        }
    }

    public class SequenceComputer : Computer
    {
        public SequenceComputer(int low, int high) : base("SequenceComputer", low, high)
        {
            OldNumber = Low - 1;
        }

        public override int GuessNumber(int lastGuess)
        {
            OldNumber++;
            return OldNumber;
        }
    }

    public class BinaryComputer : Computer
    {
        public BinaryComputer(int low, int high) : base("BinaryComputer", low, high)
        {
            //OldNumber = (low + high) / 2;
        }
        public override int GuessNumber(int lastGuess)
        {
            if (lastGuess == LESS_THAN) Low = OldNumber;                
            else if (lastGuess == GREATER_THAN) High = OldNumber;

            OldNumber = (Low + High) / 2;
            return OldNumber;
        }
    }
}