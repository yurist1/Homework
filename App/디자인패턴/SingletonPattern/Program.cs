using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
          

            for (int i = 0; i < 10; i++)
            {
                var singleton = Singleton.instance();
                var singleton1 = Singleton.instance();
                if (singleton == singleton1) 
                {
                    singleton.log(singleton.ToString() +" "+ i);
                }
         
            }
            Console.Read();
        }
    }
}
