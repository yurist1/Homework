using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Move
{
    class GroundMove : IMovement
    {
        public void Move()
        {
            Console.WriteLine("GROUND MOVE!!!! MOVE BY MY FOOT");
        }
    }
}
