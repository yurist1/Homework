using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Baddy-Long-Legs"));
            Iterator it = bookShelf.iterator();

            while (it.hasNext())
            {
                Book book = (Book)it.next(); 
                Console.WriteLine(book.GetName());
            }
            Console.ReadLine();
        }
    }
}
