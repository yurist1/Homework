using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Fruit : Element
    {
        public void accept(Visitor visitor)
        {
            Console.WriteLine("과일이 준비되었습니다.");
            visitor.visit(this);
        }
    }
}
