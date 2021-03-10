using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopper shopper = new Shopper();
            Cart cart = new Cart();
            cart.accept(shopper);

            Console.Read();
        }
    }
}
