using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainRespPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IHandler c1 = new NegativeProcessor();
            IHandler c2 = new ZeroProcessor();
            IHandler c3 = new PositiveProcessor();

            c1.setNext(c2);
            c2.setNext(c3);

            c1.process(new Number(90));
            c1.process(new Number(-50));
            c1.process(new Number(0));
            c1.process(new Number(91));

            Console.Read();
        }
    }
}
