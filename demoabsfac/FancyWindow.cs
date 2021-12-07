using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoabsfac
{
    public class FancyWindow : Window
    {
        public FancyWindow()
        {
            // nothing todo
        }

        public FancyWindow(int w, int h) : base(w, h)
        {
            // nothing todo
        }

        public override void Draw()
        {
            System.Console.Write("+");
            for (int i = 0; i < Width; i++) System.Console.Write("~~");
            System.Console.WriteLine("+");

            for (int k = 0; k < Height; k++)
            {
                System.Console.Write("$");
                for (int i = 0; i < Width; i++) System.Console.Write("  ");
                System.Console.WriteLine("$");
            }

            System.Console.Write("+");
            for (int i = 0; i < Width; i++) System.Console.Write("~~");
            System.Console.WriteLine("+");
        }

        
    }
}