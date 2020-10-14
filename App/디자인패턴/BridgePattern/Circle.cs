using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Circle : Shape
    {
        public Circle(Drawing drawing) : base(drawing)
        {
        }

        public override void draw()
        {
            Console.WriteLine("Circle draw extend");
        }
    }
}
