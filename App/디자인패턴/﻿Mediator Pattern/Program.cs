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
            //IMediator mediator = new ConcreteMediator();

            //ColleagueA talkColleague = new ColleagueA(mediator);
            //ColleagueB fightColleague = new ColleagueB(mediator);

            //talkColleague.doSomething();
            //fightColleague.doSomething();



            //  dotnettutorials.net/lesson/mediator-design-pattern
            FacebookGroupMediator facebookGroupMediator = new ConcreteFacebookGroupMediator();
            User Yurist = new ConcreteUser(facebookGroupMediator, "Yurist");
            User Anna = new ConcreteUser(facebookGroupMediator, "Anna");
            User Rain = new ConcreteUser(facebookGroupMediator, "Rain");
            User BTS = new ConcreteUser(facebookGroupMediator, "BTS");
            User sPark = new ConcreteUser(facebookGroupMediator, "sPark");

            facebookGroupMediator.RegisterUser(Yurist);
            facebookGroupMediator.RegisterUser(Anna);
            facebookGroupMediator.RegisterUser(Rain);
            facebookGroupMediator.RegisterUser(BTS);
            facebookGroupMediator.RegisterUser(sPark);

            Yurist.Send("Holly Molly!!!", Anna);
            Console.WriteLine();
            Anna.Send("What happen?");
            Console.Read();
        }
    }
}
