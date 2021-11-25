using System;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Print();
            r.Draw();

            Shape s = new Rectangle("ABCD", 8, 2);
            s.Print();
            s.Draw();

            s = new Square("MNPQ", 5);
            s.Print();
            s.Draw();

            s = new Triangle("ABC", 4);
            s.Print();
            s.Draw();
        }
    }
}
