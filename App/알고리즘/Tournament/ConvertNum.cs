using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament
{
    class ConvertNum
    {
        public string solution(int n)
        {

            return convertInto124(n);
        }
        private string convertInto124(int num)
        {

            string[] values = new string[3]{ "4","1","2"};
            int target = num;
            string list = "";
            while (true)
            {
                list = values[target % 3] + list;
                if (target <= 3)
                {
                    break;
                }

                if (target % 3 == 0)
                {
                    target = (target / 3) - 1;
                }
                else
                {
                    target = target / 3;
                }
            }

            return list;
        }
    }
}
