using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public class ConcreteMediator : IMediator
    {
        ColleagueA _talk;
        ColleagueB _fight;

        public void fight()
        {
            Console.WriteLine("Mediator is fighting");
        }
        public void talk()
        {
            Console.WriteLine("Mediator is talking");
        }

        public void registerA(ColleagueA a)
        {
            _talk = a;
        }

        public void registerB(ColleagueB b)
        {
            _fight = b;
        }

    }
}
