using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Patient2 : ICheckPatByB
    {
        public void getBloodSugar()
        {
            Console.WriteLine("혈당은 높습니다.");
        }

        public void getElectCardio()
        {
            Console.WriteLine("심전도는 정상치입니다.");
        }

        public void getHeight()
        {
            Console.WriteLine("키는 작습니다.");
        }

        public void getPressure()
        {
            Console.WriteLine("혈압은 정상치입니다.");
        }

        public void getWeight()
        {
            Console.WriteLine("몸무게는 정상치입니다.");
        }
    }
}
