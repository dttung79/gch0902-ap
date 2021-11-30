using System;
using System.Collections.Generic;

namespace shapes
{
    public class AddShapesProgram : Menu
    {
        private List<Shape> shapes;
        public List<Shape> Shapes
        {
            get { return shapes; }
        }
        public AddShapesProgram()
        {
            shapes = new List<Shape>();
        }

        protected override void DoTask(int choice)
        {
            throw new NotImplementedException();
        }

        protected override void PrintMenu()
        {
            throw new NotImplementedException();
        }
    }
}