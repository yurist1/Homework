using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface ICheckPatByB
    {
        void getHeight();
        void getWeight();
        void getPressure();
        void getElectCardio();
        void getBloodSugar();
    }
}
