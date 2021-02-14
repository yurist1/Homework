using StrategyPattern.Attack;
using StrategyPattern.Interface;
using StrategyPattern.Level;
using StrategyPattern.Move;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Giant : Troops
    {
        public Giant() 
        {
            movement = new GroundMove();
            attackType = new PuchAttack();
            level = new LevelOne();
        }
        public Giant(ILevel level)
        {
            movement = new GroundMove();
            attackType = new PuchAttack();
            this.level = level;
        }
        public override void Attack()
        {
            attackType.Attack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a giant!! ");
        }

        public override double Hitpoints()
        {
            return 1000 + 1000 * level.IncreaseInHitPoint();
        }

        public override double TrainingCost()
        {
            return 100 + 100 * level.IncreaseInTrainingCost();
        }

        public override double TrainingTime()
        {
            return 2 + 2 * level.IncreaseInTrainingTime();
        }
    }
}
