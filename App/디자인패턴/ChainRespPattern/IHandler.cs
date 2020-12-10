using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainRespPattern
{
    public interface IHandler
    {
        void setNext(IHandler next);
        void process(Number request);
    }
}
