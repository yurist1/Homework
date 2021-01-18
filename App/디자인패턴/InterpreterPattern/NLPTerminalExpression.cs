using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class NLPTerminalExpression : NLPExpression
    {
        private string data;
        public NLPTerminalExpression(string data) 
        {
            this.data = data;
        }
        public object interpreter(string con)
        {
            throw new NotImplementedException();
        }
    }
}
