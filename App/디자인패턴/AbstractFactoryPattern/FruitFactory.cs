using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FruitFactory : BeverageFactory
    {
        private bool isCold;
        public FruitFactory(bool iscold) 
        {
            isCold = iscold;
        }
        public override Beverage createBeverage()
        {
            return new CoffeeBeverage(isCold);
        }

        public override Order createOrder()
        {
            throw new NotImplementedException();
        }

        public override Service createService()
        {
            throw new NotImplementedException();
        }
    }
}
