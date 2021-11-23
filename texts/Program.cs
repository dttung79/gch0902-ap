using System;

namespace texts
{
    class Program
    {
        static void Main(string[] args)
        {
            Text msg = new Text("Design Pattern");
            msg.PrintLn();

            //FancyText fctext = new FancyText("Hello C#");
            //fctext.Print();

            msg = new FancyText("Hello C#");
            msg.Print();

            msg.Content = "abcxyz";
        }
    }
}
