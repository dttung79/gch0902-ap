using System;

namespace shapes
{
    public abstract class Menu
    {
        protected const int EXIT = 0;
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == EXIT) running = false;
            }
        }

        protected int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        protected abstract void PrintMenu();
        protected abstract void DoTask(int choice);
    }
}