using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shapes
{
    public class Square : Rectangle
    {
        // TODO:
        // - Default constructor
        public Square()
        {
            type = "Square";
            Width = Height = 4;
        }
        // - Parameter constructor
        public Square(string name, int side) : base(name, side, side)
        {
            // nothing todo
        }
    }
}