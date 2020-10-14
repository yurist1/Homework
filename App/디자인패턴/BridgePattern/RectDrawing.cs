using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class RectDrawing : Drawing
    {
        public void color(int color)
        {
            Console.WriteLine($"Rectangle change color to {color}");
        }

        public void drawSolid(int dp)
        {
            Console.WriteLine($"draw Rectangle solid in {dp} thickness");
        }

        public void fill()
        {
            Console.WriteLine($"FILL RECT");
        }
    }
}
