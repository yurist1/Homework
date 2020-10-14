using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape retangle = new Retangle(new RectDrawing());
            Shape circle = new Circle(new CircleDrawing());


            Console.WriteLine("==LET'S DRAW RECT==");
            retangle.drawSolid(3);
            retangle.fill();
            retangle.color(11111);
            retangle.draw();
            Console.WriteLine("==LET'S DRAW CIRCLE==");
            circle.drawSolid(3);
            circle.fill();
            circle.color(11111);
            circle.draw();
            Console.ReadLine();
        }
    }
}
