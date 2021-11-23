using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace texts
{
    public class FancyText : Text
    {
        // TODO:
        // FancyText inherites from Text
        // Implement: default constructor, parameter constructor
        // Override Print method to print content in fancy way
        public FancyText() // implicitly call default constructor of Text
        {
            // nothing todo
        }

        public FancyText(string content) : base(content)
        {
            // nothing todo
        }

        public void Print()
        {
            PrintLine(); // +--------+
            System.Console.Write("|");
            base.Print(); // print content
            System.Console.WriteLine("|");
            PrintLine(); // +-------+
        }
        private void PrintLine()
        {
            System.Console.Write("+");
            foreach (char c in Content)
            {
                System.Console.Write("-");
            }
            System.Console.WriteLine("+");
        }
    }
}