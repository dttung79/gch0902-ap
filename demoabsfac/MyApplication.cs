using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoabsfac
{
    public class MyApplication
    {
        private Window window;
        private Header header;

        private WidgetFactory factory;

        public MyApplication()
        {
            factory = new SimpleWidgetFactory();
            window = factory.CreateWindow(15, 8);
            header = factory.CreateHeader(15, "New window");
        }

        public void Draw() 
        {
            header.Draw();
            window.Draw();
        }

        public void ChangeTheme(string theme)
        {
            if (theme == "Simple") factory = new SimpleWidgetFactory();
            else factory = new FancyWidgetFactory();
            
            UpdateInteface();

        }

        private void UpdateInteface() {
            int w = window.Width;
            int h = window.Height;
            string title = header.Title;

            window = factory.CreateWindow(w, h);
            header = factory.CreateHeader(w, title);

            Draw();
        }
    }
}