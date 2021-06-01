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
            int target = num;
            string list = "";
            while (true)
            {
                if (target <= 3)
                {
                    list = target + list;
                    break;
                }

                if (target % 3 == 0)
                {
                    list = 3 + list;
                    target = (target / 3) - 1;
                }
                else
                {
                    list = (target % 3) + list;
                    target = target / 3;
                }
            }

            list.Replace("3", "4");


            return list.Replace("3", "4");
        }
    }
}
