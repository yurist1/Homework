using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BookShelfIterator : Iterator
    {
        private BookShelf bookShelf;
        private int index;
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf; 
            this.index = 0;

        }
        public bool hasNext()
        {
            if (index < bookShelf.GetLength())
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public object next()
        {
            Book book = bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}
