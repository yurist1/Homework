using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Attack
{
    class FlyAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("i can fly also attack!!!  hahah!!");
        }
    }
}
