using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public abstract class IColleague
    {
        public IMediator mediator;
        public abstract void doSomething();
    }
}
