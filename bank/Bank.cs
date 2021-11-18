using System;
using System.Collections.Generic;

namespace bank
{
    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            accounts = new List<Account>(); // accounts is empty
        }

        public void AddAccount()
        {
            System.Console.Write("Enter account name: ");
            String name = Console.ReadLine();

            System.Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Account acc = new Account(name, balance);
            accounts.Add(acc);
        }

        public void ShowAccount()
        {
            System.Console.Write("Enter account id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            // for (int i = 0; i < accounts.Count; i++)
            // {
            //     if (accounts[i].ID == id)
            //     {
            //         found = true;
            //         accounts[i].ShowInfo();
            //     }
            // }
            foreach (Account acc in accounts)
            {
                if (acc.ID == id)
                {
                    found = true;
                    acc.ShowInfo();
                }
            }

            if (!found) System.Console.WriteLine("ID not found!");
        }

        public void ShowAllAccounts()
        {
            // TODO: Homework
        }

        public void EditAccount()
        {
            // TODO: Homework -> find account by id, enter new info
            // use set property to update
        }

        public void DeleteAccount()
        {
            // TODO: Homework -> find account by id, delete (use method in List)
        }
    }
}