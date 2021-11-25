using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shapes
{
    public abstract class Shape
    {
        public string Name { get; set; }
        protected string type;
        public string Type 
        {
            get { return type; }
        }

        public Shape()
        {
            type = "Shape";
            Name = "No name";
        }

        public Shape(string name) 
        {
            type = "Shape";
            Name = name;
        }
        public abstract void Draw();

        public virtual void Print()
        {
            System.Console.WriteLine(Type + ": " + Name);
        }
    }
}