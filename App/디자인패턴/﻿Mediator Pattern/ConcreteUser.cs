using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{this.name} -> Received Message : {message}");
        }

        public override void Send(string message, User user = null)
        {
            Console.WriteLine($"{this.name} -> Sending Message : {message} \n");
            if (user == null)
                mediator.SendMessage(message);
            else
                mediator.SendMessage(message, user);
        }
    }
}
