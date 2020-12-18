using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    //NonTerminalExpression
    public class OrExpression : AbstractExpression
    {
        private AbstractExpression expr1;
        private AbstractExpression expr2;

        public OrExpression(AbstractExpression expr1, AbstractExpression expr2) 
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }
        public bool interpreter(string con)
        {
            return expr1.interpreter(con) || expr2.interpreter(con);
        }
    }
}
