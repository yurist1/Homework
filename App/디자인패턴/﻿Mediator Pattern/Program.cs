using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _﻿Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new ConcreteMediator();

            ColleagueA talkColleague = new ColleagueA(mediator);
            ColleagueB fightColleague = new ColleagueB(mediator);

            talkColleague.doSomething();
            fightColleague.doSomething();

            Console.Read();
        }
    }
}
