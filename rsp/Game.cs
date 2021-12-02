using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rsp
{
    public class Game
    {
        private Player human;
        private Player comp;

        private const int HUMAN_WIN = 1;
        private const int COMP_WIN = 2;
        private const int DRAW = 3;

        private const int ROCK = 1;
        private const int SCISSOR = 2;
        private const int PAPER = 3;

        public Game()
        {
            human = new Human();
            comp = new Computer();
        }

        public void Start()
        {
            // Set player name
            System.Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            human.Name = name;

            // Set max score
            System.Console.Write("Enter max points to win: ");
            int maxPoints = Convert.ToInt32(Console.ReadLine());

            bool gameOver = false;

            while (!gameOver)
            {
                int compChoice = comp.Pick();
                int hoomChoice = human.Pick();
                
                printChoices(compChoice, hoomChoice);
                
                int status = checkChoices(hoomChoice, compChoice);

                if (status == HUMAN_WIN) human.Points += 1;
                else if (status == COMP_WIN) comp.Points += 1;


                gameOver = human.Points == maxPoints || comp.Points == maxPoints;
            }

            if (human.Points == maxPoints) System.Console.WriteLine(human.Name + " WIN GAME");
            else System.Console.WriteLine(comp.Name + " WIN GAME");
        }

        private int checkChoices(int hoomChoice, int compChoice)
        {
            // 1 >> 2 >> 3 >> 1
            if (hoomChoice == ROCK && compChoice == SCISSOR 
             || hoomChoice == SCISSOR && compChoice == PAPER 
             || hoomChoice == PAPER && compChoice == ROCK) 
            {
                System.Console.WriteLine(human.Name + " wins!");
                return HUMAN_WIN;
            }

            if (compChoice == ROCK && hoomChoice == SCISSOR ||
                compChoice == SCISSOR && hoomChoice == PAPER ||
                compChoice == PAPER && hoomChoice == ROCK) 
            {
                System.Console.WriteLine(comp.Name + " wins");
                return COMP_WIN;
            }
            System.Console.WriteLine("Draw!");
            return DRAW;
        }

        private void printChoices(int compChoice, int hoomChoice)
        {
            System.Console.WriteLine("Computer: " + getChoice(compChoice));
            System.Console.WriteLine("Human   : " + getChoice(hoomChoice));
        }

        private string getChoice(int choice)
        {
            switch (choice) 
            {
                case ROCK: return "ROCK";
                case SCISSOR: return "SCISSOR";
                case PAPER: return "PAPER";
                default: return "INVALID";
            }
        }
    }
}