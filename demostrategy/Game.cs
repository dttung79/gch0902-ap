using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demostrategy
{
    public class Game
    {
        private Human player;
        private Computer comp;

        public Game()
        {
            System.Console.Write("Enter human name: ");
            string name = Console.ReadLine();
            player = new Human(name);

            System.Console.WriteLine("Choose computer strategy");
            System.Console.WriteLine("1. Random");
            System.Console.WriteLine("2. Sequence");
            System.Console.WriteLine("3. Binary");

            System.Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: comp = new RandomComputer(1, 100); break;
                case 2: comp = new SequenceComputer(1, 100); break;
                case 3: comp = new BinaryComputer(1, 100); break;
                default: comp = new RandomComputer(1, 100); break;
            }
        }

        public void Play()
        {
            System.Console.WriteLine(player.Name + " vs " + comp.Name);
            bool running = true;
            int number = player.ChooseNumber(1, 100);
            int lastGuess = 0;
            int guessCount = 0;
            while (running)
            {
                int guessNumber = comp.GuessNumber(lastGuess);
                System.Console.WriteLine("Computer number: " + guessNumber);
                Console.ReadKey();
                guessCount++;
                if (number == guessNumber)
                {
                    System.Console.WriteLine("Computer win after " + guessCount + " guesses!");
                    running = false;
                }
                else if (guessNumber < number)
                {
                    lastGuess = Computer.LESS_THAN;
                    System.Console.WriteLine("Less than human number");
                    System.Console.WriteLine("Total guesses so far: " + guessCount);
                } else 
                {
                    lastGuess = Computer.GREATER_THAN;
                    System.Console.WriteLine("Greater than human number");
                    System.Console.WriteLine("Total guesses so far: " + guessCount);
                }
            }
        }
    }
}