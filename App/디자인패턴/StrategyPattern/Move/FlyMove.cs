using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Move
{
    class FlyMove : IMovement
    {
        public void Move()
        {
            Console.WriteLine("FLY and MOVE");
        }
    }
}
