using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyweightPattern_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var factory = new ButtonFactory();
            InitializeComponent();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                var btn = factory.GetButtonWeight();
                btn.Location = new Point(100, 40*i);
                this.Controls.Add(btn);
            }
        }

    }
}
