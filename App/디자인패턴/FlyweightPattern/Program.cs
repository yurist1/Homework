using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            IFlyweight[] flyweights = new IFlyweight[]
            {
            flyweightFactory.GetFlyweight("A"),
            flyweightFactory.GetFlyweight("A"),
            flyweightFactory.GetFlyweight("B"),
            flyweightFactory.GetFlyweight("C"),
            flyweightFactory.GetFlyweight("C")
            };

            foreach (IFlyweight flyweight in flyweights)
            {
                flyweight.Operation();
            }
            Console.Read();
        }
    }
}
