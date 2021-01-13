using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public interface NLPExpression
    {
       object interpreter(string con);
    }
}
