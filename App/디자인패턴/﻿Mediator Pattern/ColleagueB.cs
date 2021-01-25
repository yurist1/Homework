using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public class ColleagueB : IColleague
    {
        public ColleagueB(IMediator mediator) 
        {
            this.mediator = mediator;
            this.mediator.registerB(this);
        }
        public override void doSomething()
        {
            this.mediator.fight();
        }
    }
}
