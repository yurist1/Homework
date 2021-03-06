﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainRespPattern
{
    public class NegativeProcessor : IHandler
    {
        private IHandler nextChain;

        public void setNext(IHandler next)
        {
            this.nextChain = next;
        }
        public void process(Number request)
        {
            if (request.getNumber() < 0)
            {
                Console.WriteLine($"NegativeProcessor : {request.getNumber()}");
            }
            else 
            {
                nextChain.process(request);
            }
        }

    }
}
