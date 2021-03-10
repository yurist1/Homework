using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Milk : Element
    {
        public void accept(Visitor visitor)
        {
            Console.WriteLine("우유가 준비되었습니다.");
            visitor.visit(this);
        }
    }
}
