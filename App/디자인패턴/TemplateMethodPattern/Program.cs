using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Same client code can work with different subclasses:");

            //Client.ClientCode(new ConcreteClass1());

            //Console.Write("\n");

            //Console.WriteLine("Same client code can work with different subclasses:");
            //Client.ClientCode(new ConcreteClass2());

            //Console.ReadLine();


            Coffee getCoffee = new CustomCoffee();
            getCoffee.MakeCoffee();

            Console.ReadLine();
        }
    }
}
