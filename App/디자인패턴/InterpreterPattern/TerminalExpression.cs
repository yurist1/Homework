using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class TerminalExpression : AbstractExpression
    {
        private string data;
        public TerminalExpression(string data) 
        {
            this.data = data;
        }
        public bool interpreter(string con)
        {
            if (con.Contains(data))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
