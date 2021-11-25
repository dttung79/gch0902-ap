using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shapes
{
    public class Triangle : Shape
    {
        public int Side { get; set; }
        
        // TODO:
        // - default constructor
        // - parameter constructor
        // - override Print method
        // - override Draw method
        public Triangle()
        {
            type = "Triangle";
            Side = 4;
        }
        public Triangle(string name, int side) : base(name)
        {
            type = "Triangle";
            Side = side;
        }
        public override void Print()
        {
            base.Print();
            System.Console.WriteLine("Side = " + Side);
        }

        public override void Draw()
        {
            for (int i = 1; i <= Side; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }
        }
    }
}