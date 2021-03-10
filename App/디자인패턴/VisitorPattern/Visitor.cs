using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface Visitor
    {
        //void visit(Element element);
        void visit(Cart element);
        void visit(Fruit element);
        void visit(Milk element);
    }
}
