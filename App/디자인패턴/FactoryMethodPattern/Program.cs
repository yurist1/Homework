using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizza = new MrPizzaStore();


            pizza.createPizza("Cheese");
            pizza.orderPizza("Cheese");
        }
    }
}
