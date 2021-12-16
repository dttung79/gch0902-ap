using System;

namespace democomposite
{
    class Program
    {
        static void Main(string[] args)
        {
            File f = new File();
            f.Show();

            f = new File("test.txt", 150);
            f.Show();

            Directory d = new Directory("C");
            System.Console.WriteLine("-----------------------------");
            d.Show();
            d.AddChild(f);
            System.Console.WriteLine("-----------------------------");
            d.Show();

            Directory doc = new Directory("Documents");
            doc.AddChild(new File("A1.docx", 200));
            doc.AddChild(new File("A2.docx", 250));
            doc.AddChild(new Directory());

            d.AddChild(doc);
            System.Console.WriteLine("-----------------------------");
            d.Show();
        }
    }
}
