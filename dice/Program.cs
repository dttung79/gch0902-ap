using System;

namespace DiceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dice d = new Dice(); // call default constructor
            // // d.Number = 100; // use property -> call set of property
            // // Console.WriteLine(d.Number); // use property -> call get of property

            // // d = new Dice(10); // call parameter constructor
            // // System.Console.WriteLine(d.Number);

            // d.Roll();
            // System.Console.WriteLine(d.Number);
            // d.Roll();
            // System.Console.WriteLine(d.Number);
            Game diceGame = new Game();
            diceGame.Play();
        }
    }
}
