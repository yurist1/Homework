using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Patient1 : ICheckPatByA
    {
        public void getHeight()
        {
            Console.WriteLine("키가 큽니다.");
        }

        public void getPressure()
        {
            Console.WriteLine("혈압은 정상치입니다.");
        }

        public void getWeight()
        {
            Console.WriteLine("몸무게는 많이 나갑니다.");
        }
    }
}
