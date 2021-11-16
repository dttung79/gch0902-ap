using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceProject
{
    public class Game
    {
        private Dice dice;
        private Player player;

        public Game()
        {
            dice = new Dice();
            // create player object
            System.Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter money to play: ");
            int money = Convert.ToInt32(Console.ReadLine());
            player = new Player(name, money);
        }

        public void Play()
        {
            bool isPlaying = true;
            while (isPlaying)
            {
                dice.Roll();
                int amount = player.Bet();
                int number = player.Guess();

                if (number == dice.Number)
                {
                    System.Console.WriteLine("You win $" + (6 * amount) + "!");
                    player.Money += 6 * amount;
                }
                else
                {
                    System.Console.WriteLine("Wrong! Number is: " + dice.Number);
                    System.Console.WriteLine("You loose $" + amount + "!");
                }

                System.Console.WriteLine("Current balance: $" + player.Money);
                
                isPlaying = !player.IsStopGame();
            }
            System.Console.WriteLine("Goodbye and see you again!");
        }
    }
}