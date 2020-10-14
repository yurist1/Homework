using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface Drawing
    {
        void drawSolid(int dp);
        void fill();
        void color(int color);
    }
}
