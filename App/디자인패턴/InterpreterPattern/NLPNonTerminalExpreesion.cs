using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class NLPNonTerminalExpreesion : NLPExpression
    {
        string[] data;
        public NLPNonTerminalExpreesion(string data)
        {
            if (data.Contains("."))
            {
                this.data = data.Split('.');
            }
            else if (data.Contains(" "))
            {
                this.data = data.Split(' ');
            }
        }
        public object interpreter(string con)
        {
            foreach (var item in data)
            {
                if (item.Contains(" "))
                {
                    NLPNonTerminalExpreesion expr1 = new NLPNonTerminalExpreesion(item);
                    return expr1.interpreter(item);
                }
            }
            //터미널
            NLPTerminalExpression expr4 = new NLPTerminalExpression("");
            return expr4.interpreter(con);
        }
    }
}
