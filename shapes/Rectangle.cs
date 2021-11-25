using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shapes
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Rectangle() 
        {
            type = "Rectangle";
            Width = 4;
            Height = 2;
        }

        public Rectangle(string name, int width, int height) : base(name)
        {
            Name = name;
            Width = width;
            Height = height;
            type = "Rectangle";
        }

        public override void Print()
        {
            base.Print();
            System.Console.WriteLine("Dimension: (" + Width + ", " + Height + ")");
        }
        public override void Draw()
        {
            for (int i = 0; i < Width * 3; i++) System.Console.Write("-");
            System.Console.WriteLine();

            for (int i = 0; i < Height; i++)
            {
                System.Console.Write("|");
                for (int j = 0; j < Width * 3 - 2; j++) System.Console.Write(" ");
                System.Console.WriteLine("|");
            }

            for (int i = 0; i < Width * 3; i++) System.Console.Write("-");
            System.Console.WriteLine();
        }
    }
}