using System;

namespace demoabsfac
{
    class Program
    {
        static void Main(string[] args)
        {
            // FancyHeader h = new FancyHeader(10, "Test");
            // h.Draw();
            // FancyWindow w = new FancyWindow(10, 4);
            // w.Draw();
            MyApplication app = new MyApplication();
            app.Draw();

            System.Console.WriteLine("Change them:");
            System.Console.WriteLine("1. Simple");
            System.Console.WriteLine("2. Fancy");
            System.Console.Write("Your choice: ");

            string theme = Console.ReadLine();
            app.ChangeTheme(theme);
        }
    }
}
