using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CoffeeOrder : Order
    {
        protected override void getOrder()
        {
            Console.WriteLine("커피 주문 완료되었습니다. ");
        }
    }
}
