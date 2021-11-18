using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc01 = new Account(); // call default constructor
            Account acc02 = new Account("Nguyen Van Linh", 1000);

            acc01.ShowInfo();
            acc02.ShowInfo();

            Account acc03 = new Account("John Lennon", 5000);
            acc03.ShowInfo();
        }
    }
}
