using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Service
    {
        public void giveService() 
        {
            Console.WriteLine("주문하신 음료 나왔습니다. ");
        }
        public void checkService() 
        {
            Console.WriteLine("매출 +1 !!!!!!!!!!!!🥨🥨 ");
        }
    }
}
