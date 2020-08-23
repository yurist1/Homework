using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeFactory cf = new CoffeeFactory(true);

            cf.createOrder();
            cf.createBeverage();
            cf.createService();

            Console.Read();
        }
    }
}
