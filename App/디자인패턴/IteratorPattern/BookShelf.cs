using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BookShelf : Aggregate
    {
        private Book[] books;
        private int last = 0;
        public BookShelf(int size)
        {
            this.books = new Book[size];
        }
        public Book GetBookAt(int index)
        {
            return books[index];
        }
        public void AppendBook(Book book)
        {
            this.books[last] = book;
            last++;
        }
        public int GetLength() 
        {
            return last;
        }


        public Iterator iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
