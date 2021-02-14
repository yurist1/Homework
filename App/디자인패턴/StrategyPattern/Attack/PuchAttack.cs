using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Attack
{
    class PuchAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("My puch is really spicy!!!! haha!!");
        }
    }
}
