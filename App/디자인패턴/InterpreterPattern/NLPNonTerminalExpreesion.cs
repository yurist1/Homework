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
                    NLPExpression expr1 = new NLPNonTerminalExpreesion(item);
                    return expr1.interpreter(item);
                }
                else 
                {
                    //터미널
                    NLPTerminalExpression expr2 = new NLPTerminalExpression(data);
                    return expr2.interpreter(item);
                }
            }

            return null;
        }
    }
}
