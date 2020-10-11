using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Adapter : ICheckPatByB
    {
        ICheckPatByA mCheckPatA;

        public Adapter(ICheckPatByA checkPatA) 
        {
            mCheckPatA = checkPatA;
        }

        public void getBloodSugar()
        {
            Console.WriteLine("A기계 사용 - 혈당 측정 불가 ");
        }

        public void getElectCardio()
        {
            Console.WriteLine("A기계 사용 - 심전도 측정 불가 ");
        }

        public void getHeight()
        {
            mCheckPatA.getHeight();

        }

        public void getPressure()
        {
            mCheckPatA.getPressure();
        }

        public void getWeight()
        {
            mCheckPatA.getWeight();
        }
    }
}
