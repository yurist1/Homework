using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Troops
    {
        protected IAttack attackType;
        protected ILevel level;
        protected IMovement movement;

        public int HousingSpace() 
        {
            return 5;
        }

        
        public abstract void Attack();
        public abstract double TrainingTime();
        public abstract double TrainingCost();
        public abstract double Hitpoints();
        public abstract void Display();
    }
}
