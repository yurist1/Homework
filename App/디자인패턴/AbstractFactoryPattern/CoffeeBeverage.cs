using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CoffeeBeverage : Beverage
    {
        public CoffeeBeverage(bool isCold) : base(isCold)
        {
            //if (isCold)
            //{
            //    iceBeverage();
            //}
            //else 
            //{
            //    hotBeverage();
            //}

  
        }

        protected override void hotBeverage()
        {
            Console.WriteLine("물을 팔팔 끓이고 ");
            Console.WriteLine("커피 내리고");
            Console.WriteLine("뜨거운 물 +커피");
        }

        protected override void iceBeverage()
        {
            Console.WriteLine("얼음 준비하고 ");
            Console.WriteLine("커피내리고");
            Console.WriteLine("얼음 + 커피");
        }
    }
}
