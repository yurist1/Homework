using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Context context;

            //// Three contexts following different strategies

            //context = new Context(new ConcreteStrategyA());
            //context.ContextInterface();

            //context = new Context(new ConcreteStrategyB());
            //context.ContextInterface();

            // Wait for user



            //classic of clane
            Console.WriteLine("WELCOME TO CLASH OF CLANS!!");
            Console.WriteLine("============================\n\n");

            CCContext context = new CCContext(new Giant());
            context.GetTroopInfo();

            Console.ReadKey();
        }
    }
}
