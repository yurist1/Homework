using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> _flyweights;
        public FlyweightFactory() 
        {
            _flyweights = new Dictionary<string, IFlyweight>();
        }
        public IFlyweight GetFlyweight(string key) 
        {
            IFlyweight flyweight;
            _flyweights.TryGetValue(key, out flyweight);
            if (flyweight == null) 
            {
                flyweight = new Flyweight();
                _flyweights.Add(key, flyweight);
            }
            return flyweight;
        }
    }
}
