using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_26_DataGridView
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }
    }

    public class BookStore: IEnumerable
    {
        private List<Book> books = null;
        public BookStore()
        {
            books = new List<Book>()
            {
                new Book{Author = "А. Будай",Title = "Паттерни - просто як двері",  Available = true},
                new Book{Author = "Р. Мартін", Title = "Чистий код", Available = false},
                new Book{Author = "Троелсен",  Title = ".NET 8.0", Available = true}
            };
        }
        public void Add(Book book)
        {
            books.Add(book);
        }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }
}
