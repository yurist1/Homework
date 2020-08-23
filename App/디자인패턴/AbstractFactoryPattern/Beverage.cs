using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Beverage
    {
        private bool mIsCold;
        public Beverage(bool isCold) 
        {
            if (isCold)
            {
                iceBeverage();
            }
            else 
            {
                hotBeverage();
            }

        }

        protected abstract void iceBeverage();
        protected abstract void hotBeverage();
    }
}
