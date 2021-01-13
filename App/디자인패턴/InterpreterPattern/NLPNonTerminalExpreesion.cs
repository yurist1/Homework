using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class NLPNonTerminalExpreesion : NLPExpression
    {
        private NLPExpression expr1;

        public NLPNonTerminalExpreesion(NLPExpression expr1) 
        {
            this.expr1 = expr1;
        }
        public object interpreter(string con)
        {
            throw new NotImplementedException();
        }
    }
}
