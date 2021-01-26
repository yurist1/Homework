using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public interface FacebookGroupMediator
    {
        void SendMessage(string msg, User user= null);
        void RegisterUser(User user);
    }
}
