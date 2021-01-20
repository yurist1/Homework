using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class NLPTerminalExpression : NLPExpression
    {
        private string[] data;
        public NLPTerminalExpression(string[] data) 
        {
            this.data = data;
        }
        public object interpreter(string con)
        {
            string result = "";
            var length = data.Length;

            if (length <= 3 )
            {
                
            }

            //and 기준으로 문장 쪼개기 
            //조사(은는이가을를)는 하드코딩으로


            return null;
        }
    }
}
