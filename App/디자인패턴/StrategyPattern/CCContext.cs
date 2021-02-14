using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CCContext
    {
        private Troops troops;
        public CCContext(Troops troops) 
        {
            this.troops = troops;
        }
        public void GetTroopInfo() 
        {
            troops.Display();
            troops.Attack();
            troops.Hitpoints();
            troops.TrainingCost();
            troops.TrainingTime();
        }
    }
}
