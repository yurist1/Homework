using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Waiter
    {
        private PizzaBuilder pizzaBuilder;
        public void SetPizzaBuilder(PizzaBuilder pd) 
        {
            pizzaBuilder = pd;
        }
        public Pizza GetPizza() 
        {
            return pizzaBuilder.GetPizza();
        }

        public void ConstructPizza() 
        {
            pizzaBuilder.CreatNewPizza();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
}
