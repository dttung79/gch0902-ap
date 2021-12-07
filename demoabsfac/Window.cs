using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoabsfac
{
    public abstract class Window
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Window()
        {
            Width = 80;
            Height = 25;
        }

        public Window(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public abstract void Draw();
    }
}