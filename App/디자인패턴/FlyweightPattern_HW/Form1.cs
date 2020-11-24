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
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add(AddBtn(i));
            }
        }

        private Button AddBtn(int position)
        {
            Button btn = new Button();
            btn.Text = "New Button";
            btn.Location = new Point(100, 30* position);

            return btn;
        }
    }
}
