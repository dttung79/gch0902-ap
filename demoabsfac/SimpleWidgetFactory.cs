using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoabsfac
{
    public class SimpleWidgetFactory : WidgetFactory
    {
        public override Header CreateHeader(int w, string title)
        {
            return new SimpleHeader(w, title);
        }

        public override Window CreateWindow(int w, int h)
        {
            return new SimpleWindow(w, h);
        }

    }
}