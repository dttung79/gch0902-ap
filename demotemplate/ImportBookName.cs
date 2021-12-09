using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demotemplate
{
    public class ImportBookName : ImportBook
    {
        protected override void SortBooks(List<Book> books)
        {
            for (int i = 0; i < books.Count - 1; i++)
            {
                for (int j = i + 1; j < books.Count; j++)
                {
                    if (books[i].Name.CompareTo(books[j].Name) > 0) // books[i].Pages > books[j].Pages
                    {
                        Book temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }
        }
    }
}