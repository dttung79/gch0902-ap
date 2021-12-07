using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoabsfac
{
    public abstract class WidgetFactory
    {
        public abstract Window CreateWindow(int w, int h);
        public abstract Header CreateHeader(int w, string title);
    }
}