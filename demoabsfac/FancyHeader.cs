using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoabsfac
{
    public class FancyHeader : Header
    {
        public FancyHeader()
        {
        }

        public FancyHeader(int w, string title) : base(w, title)
        {
        }

        public override void Draw()
        {
            System.Console.Write("+");
            for (int i = 0; i < Width; i++) System.Console.Write("~~");
            System.Console.WriteLine("+");

            System.Console.Write("$");
            for (int i = 0; i < Title.Length; i++)
                System.Console.Write(Title[i] + " ");
                
            for (int i = 0; i < Width - Title.Length; i++) 
                System.Console.Write("  ");
            
            System.Console.WriteLine("$");
        }

        
    }
}