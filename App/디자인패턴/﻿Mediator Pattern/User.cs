﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public abstract class User
    {
        protected FacebookGroupMediator mediator;
        protected string name;

        public User(FacebookGroupMediator mediator, string name) 
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message, User user = null);
        public abstract void Receive(string message);
    }
}
