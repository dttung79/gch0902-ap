using System;
using System.Collections.Generic;

namespace demotemplate
{
    public abstract class ImportBook
    {
        public List<Book> Import()
        {
            List<Book> books = AddBooks();
            SortBooks(books);
            ViewBooks(books);
            return books;
        }

        private void ViewBooks(List<Book> books)
        {
            foreach(Book b in books)
                System.Console.WriteLine(b);
        }

        protected List<Book> AddBooks() 
        {
            System.Console.Write("Enter number of books: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Enter book name: "); 
                string name = Console.ReadLine();

                System.Console.Write("Enter number of pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                System.Console.Write("Enter price: ");
                int price = Convert.ToInt32(Console.ReadLine());

                Book b = new Book(name, pages, price);
                books.Add(b);                
            }
            return books;
        }

        protected abstract void SortBooks(List<Book> books);

        
    }
}