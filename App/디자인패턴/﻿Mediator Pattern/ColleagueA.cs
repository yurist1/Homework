using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public class ColleagueA : IColleague
    {
        public ColleagueA(IMediator mediator) 
        {
            this.mediator = mediator;
        }
        public override void doSomething()
        {
            this.mediator.talk();
            this.mediator.registerA(this);
        }
    }
}
