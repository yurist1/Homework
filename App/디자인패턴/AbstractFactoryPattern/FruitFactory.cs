using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FruitFactory : BeverageFactory
    {
        public override Beverage createBeverage()
        {
            throw new NotImplementedException();
        }

        public override Order createOrder()
        {
            return new CoffeeOrder();
        }

        public override Service createService()
        {
            throw new NotImplementedException();
        }
    }
}
