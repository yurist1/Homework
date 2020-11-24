﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Flyweight : IFlyweight
    {
        public void Operation()
        {
            Console.WriteLine("Operating Flyweight (" + GetHashCode() + ")");
        }
    }
}
