using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface Aggregate
    {
        Iterator iterator();
    }
    public interface Iterator
    {
        bool hasNext();
        object next();
    }
}
