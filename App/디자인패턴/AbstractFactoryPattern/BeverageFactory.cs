using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    abstract class BeverageFactory
    {
        public abstract Order createOrder();
        public abstract Beverage createBeverage();
        public abstract Service createService();
    }
}
