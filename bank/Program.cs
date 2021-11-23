using System;

namespace bank
{
    class Program
    {
        private Bank vcb;
        public Program()
        {
            vcb = new Bank();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }

        private void PrintMenu()
        {
            System.Console.WriteLine("Bank Menu");
            System.Console.WriteLine("1. Add account.");
            System.Console.WriteLine("2. Show account.");
            // TODO: Homework 
            // 3. Edit account
            // 4. Show all accounts
            // 5. Delete account
            System.Console.WriteLine("3. Edit account");
            System.Console.WriteLine("4. Delete account");
            System.Console.WriteLine("5. Show all accounts");
            System.Console.WriteLine("0. Exit.");
        }
        private int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: vcb.AddAccount     (); break;
                case 2: vcb.ShowAccount    (); break;
                case 3: vcb.EditAccount    (); break;
                case 4: vcb.DeleteAccount  (); break;
                case 5: vcb.ShowAllAccounts(); break;
                case 0: break;
                default: System.Console.WriteLine("Invalid Option!"); break;
            }
        }
    }
}
    
