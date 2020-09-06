using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton singleton;
        public static Singleton instance() 
        { 
            if (singleton == null) 
            {
                singleton = new Singleton();
            }
            return singleton;
        }
        public void log(string logString) 
        {
            Console.WriteLine($"{logString}");
        }
    }
}
