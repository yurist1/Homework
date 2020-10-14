using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Shape
    {
        private Drawing drawing;

        protected Shape(Drawing drawing) 
        {
            this.drawing = drawing;
        }

        public abstract void draw();
        public void drawSolid(int dp)
        {
            drawing.drawSolid(dp);
        }
        public void fill()
        {
            drawing.fill();
        }

        public void color(int color)
        {
            drawing.color(color);
        }
    }
}
