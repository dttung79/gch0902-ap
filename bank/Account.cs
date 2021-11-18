using System;

namespace bank
{
    public class Account
    {
        public string Name { get; set; }
        private int id;
        public int ID
        {
            get { return id; }
        }
        private double balance;
        public double Balance 
        {
            get { return balance; }
            set
            {
                if (value < 0) balance = 0;
                else balance = value;
            }
        }
        private static int count = 0;

        public Account()
        {
            id = count++; // id = count; count++;
            Name = "John Doe";
            Balance = 0.0;
        }

        public Account(string name, double balance)
        {
            id = count++;
            Name = name;
            Balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Account ID     : " + ID);
            System.Console.WriteLine("Account Name   : " + Name);
            System.Console.WriteLine("Account Balance: " + Balance);
        }
    }
}