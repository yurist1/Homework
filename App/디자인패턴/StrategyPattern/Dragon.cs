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
    class Dragon : Troops
    {
        public Dragon()
        {
            movement = new FlyMove();
            attackType = new FlyAttack();
            level = new LevelOne();
        }
        public Dragon(ILevel level)
        {
            movement = new FlyMove();
            attackType = new FlyAttack();
            this.level = level;
        }
        public override void Attack()
        {
            attackType.Attack();
        }

        public override void Display()
        {
            Console.WriteLine("i'm dragon");
        }


        public override double Hitpoints()
        {
            return 1200 + 1200 * level.IncreaseInHitPoint();
        }

        public override double TrainingCost()
        {
            return 150 + 150 * level.IncreaseInTrainingCost();
        }

        public override double TrainingTime()
        {
            return 5 + 5 * level.IncreaseInTrainingTime();
        }
    }
}
