using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CoffeeFactory : BeverageFactory
    {
        private bool isCold;
        public CoffeeFactory(bool iscold) 
        {
            isCold = iscold;
        }
        public override Beverage createBeverage()
        {
            return new CoffeeBeverage(isCold);
        }

        public override Order createOrder()
        {
            return new CoffeeOrder();
        }

        public override Service createService()
        {
            return new Service();
        }
    }
}
