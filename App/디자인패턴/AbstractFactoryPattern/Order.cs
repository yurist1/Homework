using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Order
    {
        public void comeGuest() 
        {
            Console.WriteLine("손님왔다");
        } 
        protected abstract void getOrder(); 
    }
}
