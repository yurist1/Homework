using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Level
{
    class LevelTwo : ILevel
    {
        public double IncreaseInAttackRate()
        {
            return 15.0 / 100;
        }

        public double IncreaseInHitPoint()
        {
            return 20.0 / 100;
        }

        public double IncreaseInTrainingCost()
        {
            return 18.0 / 100;
        }

        public double IncreaseInTrainingTime()
        {
            return 10.0 / 100;
        }
    }
}
