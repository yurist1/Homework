using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Shopper : Visitor
    {
        public void visit(Cart element)
        {
            Console.WriteLine("Cart를 이용합니다");
        }

        public void visit(Fruit element)
        {
            Console.WriteLine("과일을 넣었습니다");
        }

        public void visit(Milk element)
        {
            Console.WriteLine("우유를 넣었습니다");
        }
    }
}
