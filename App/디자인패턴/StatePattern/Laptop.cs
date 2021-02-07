using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Laptop
    {
        private PowerState powerState;
        public Laptop() 
        {
            this.powerState = new PowerOff();
        }

        public void setPowerState(PowerState powerState) 
        {
            this.powerState = powerState;
        }
        public void powerPush() 
        {
            this.powerState.powerPush();
        }
    }
}
