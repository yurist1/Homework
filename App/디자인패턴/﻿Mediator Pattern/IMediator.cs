using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public interface IMediator
    {
        void fight();
        void talk();
        void registerA(ColleagueA a);
        void registerB(ColleagueB b);

    }
}
