using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceProject
{
    public class Player
    {
        private string name;
        private int money;

        // get/set of name    => name != ""
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        // get/set of money   => money > 0
        public int Money 
        {
            get { return money; }
            set 
            {
                if (value < 0) money = 0;
                else money = value;
            }
        }

        // Default constructor
        public Player()
        {
            name = "Player";
            money = 100;
        }
        // Parameter constructor
        public Player(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public int Bet()
        {
            System.Console.Write("Amount to bet: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount <= money)
                money -= amount;
            else
            {
                System.Console.WriteLine("Not enough money to bet. Use default value.");
                amount = money;
                money = 0;
            }
            return amount;
        }

        public int Guess() 
        {
            System.Console.Write("Guess number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // HW: Guess number in [1, 6], incorrect => reenter
            return number;
        }

        public bool IsStopGame()
        {
            if (money == 0) return true;
            System.Console.Write("Continue? (Y/N): ");
            string answer = Console.ReadLine();
            return answer.ToLower() == "n" || answer.ToLower() == "no";
        }

        
    }
}