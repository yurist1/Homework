using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface
{
    interface ILevel
    {
        double IncreaseInTrainingTime();
        double IncreaseInTrainingCost();
        double IncreaseInAttackRate();
        double IncreaseInHitPoint();
    }
}
