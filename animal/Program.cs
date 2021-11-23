using System;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog ki = new Dog();
            ki.ShowInfo();

            ki = new Dog("Ki", 5);
            ki.ShowInfo();
        }
    }
}
