using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Mediator_Pattern
{
    public class ConcreteFacebookGroupMediator : FacebookGroupMediator
    {
        private List<User> userList = new List<User>();
        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string msg, User user=null)
        {
            foreach (var item in userList)
            {
                if (user == null)
                {
                    if (item != user)
                    {
                        item.Receive(msg);
                    }
                }
                else 
                {
                    if (item == user)
                    {
                        item.Receive(msg);
                    }
                }
               
            }
        }
    }
}
