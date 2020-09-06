using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    abstract class PizzaStore
    {
        public Pizza orderPizza(string type) 
        {
            //factory 매소드 사용
            Pizza pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.packing();

            return pizza;
        }

        //factory method 
        public abstract Pizza createPizza(string type);
    }
}
