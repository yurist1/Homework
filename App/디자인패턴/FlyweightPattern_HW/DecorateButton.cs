using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyweightPattern_HW
{
    public class DecorateButton : IButton
    {
        public IButton Operation(int key)
        {
            if (btn == null) 
            {
                btn = new IButton();
            }
            //var btn = new IButton();
            switch (key) 
            {
                case 0:
                    btn.Text = ""+ GetHashCode();
                    btn.ForeColor = Color.Red;
                    break;
                default:
                    btn.Text = "" + GetHashCode();
                    btn.ForeColor = Color.Blue;
                    break;

            }
         
            return btn;
        }
    }
}
