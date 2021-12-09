using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demotemplate
{
    public class BookManager
    {
        private ImportBook importer;
        private List<Book> books;

        public BookManager()
        {            
            System.Console.WriteLine("1. Import sort by name");
            System.Console.WriteLine("2. Import sort by pages");
            System.Console.WriteLine("3. Import sort by price");
            System.Console.Write("Choose type: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1) importer = new ImportBookName();
            else if (choice == 2) importer = new ImportBookPages();
            else importer = new ImportBookPrice();
            books = new List<Book>();
        }

        public void Run()
        {            
            importer.Import();
            // search, delete, ...
        }
    }
}