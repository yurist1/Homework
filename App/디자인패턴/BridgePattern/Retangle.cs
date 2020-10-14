using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Retangle : Shape
    {
        public Retangle(Drawing drawing) : base(drawing)
        {
        }

        public override void draw()
        {
            Console.WriteLine("Rect draw extend");
        }
    }
}
