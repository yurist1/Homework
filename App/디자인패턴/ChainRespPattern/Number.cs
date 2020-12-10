using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainRespPattern
{
    public class Number
    {
        private int number;
        public Number(int num)
        {
            this.number = num;
        }
        public int getNumber() 
        {
            return number;
        }
    }
}
