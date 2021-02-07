using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Laptop laptop = new Laptop();
            PowerOn on = new PowerOn();
            PowerOff off = new PowerOff();

            laptop.powerPush();
            laptop.setPowerState(on);
            laptop.powerPush();
            laptop.setPowerState(off);
            laptop.powerPush();

            Console.Read();
        }
    }
}
