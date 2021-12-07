using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoabsfac
{
    public abstract class Header
    {
        public int Width { get; set; }

        public string Title { get; set; }

        public Header()
        {
            Width = 80;
            Title = "New Window";
        }

        public Header(int w, string title)
        {
            Width = w;
            Title = title;
        }

        public abstract void Draw();
    }
}