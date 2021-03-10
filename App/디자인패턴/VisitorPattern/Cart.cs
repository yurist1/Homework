using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Cart : Element
    {
        List<Element> carts = new List<Element>();
        public Cart() 
        {
            carts.Add(new Fruit());
            carts.Add(new Milk());


        }
        public void accept(Visitor visitor)
        {
            Console.WriteLine("Cart가 준비되었습니다");
            visitor.visit(this);

            foreach (Element item in carts)
            {
                item.accept(visitor);
            }
        }
    }
}
