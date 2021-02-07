using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class PowerOn : PowerState
    {
        public void powerPush()
        {
            Console.WriteLine("전원 OFF");
        }
    }
}
