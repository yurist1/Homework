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
            BeverageFactory[] cf = new BeverageFactory[2];
            cf[0] =   new CoffeeFactory(true);
            cf[1] =   new FruitFactory(true);


            //이게 핵심!!!!!!!!!!!!!!!!
            foreach (var item in cf)
            {
                item.createOrder();
                item.createBeverage();
                item.createService();
            }

            Console.Read();
        }
    }
}
