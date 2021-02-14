using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Level
{
    class LevelOne : ILevel
    {
        public double IncreaseInAttackRate()
        {
            return 10.0 / 100;
        }

        public double IncreaseInHitPoint()
        {
            return 12.0 / 100;
        }

        public double IncreaseInTrainingCost()
        {
            return 11.0 / 100;
        }

        public double IncreaseInTrainingTime()
        {
            return 5.0 / 100;
        }
    }
}
