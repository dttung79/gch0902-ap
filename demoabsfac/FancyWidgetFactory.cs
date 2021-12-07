using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoabsfac
{
    public class FancyWidgetFactory : WidgetFactory
    {
        public override Header CreateHeader(int w, string title)
        {
            return new FancyHeader(w, title);
        }

        public override Window CreateWindow(int w, int h)
        {
            return new FancyWindow(w, h);
        }

    }
}