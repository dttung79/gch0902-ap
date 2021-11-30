using System.Collections.Generic;

namespace demointerface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            // c.Move();

            Dog d = new Dog("Ki");
            // d.Move();

            Bird b = new Bird("Hatch");
            // b.Move();

            List<IMoveable> moves = new List<IMoveable>();
            moves.Add(c);
            moves.Add(d);
            moves.Add(b);

            foreach(IMoveable obj in moves)
            {
                obj.Move();
            }
        }
    }
}
