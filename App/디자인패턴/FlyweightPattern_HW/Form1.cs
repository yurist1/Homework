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
        private List<Button> BtnList = new List<Button>();
        public Form1()
        {
            var factory = new ButtonFactory();
            InitializeComponent();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = factory.GetButtonWeight().Text;
                btn.ForeColor = factory.GetButtonWeight().ForeColor;
                btn.Location = new Point(100, 40 * i);

                BtnList.Add(btn);

                this.Controls.Add(btn);
            }
            BtnTimer.Tick += BtnTimer_Tick;
            BtnTimer.Interval = 1000;
            BtnTimer.Start();


        }

        private void BtnTimer_Tick(object sender, EventArgs e)
        {
            //컨트롤 아이템별로 깜빡이게 설정
            foreach (var item in BtnList)
            {
                if (item.ForeColor == Color.Red)
                {
                    if (item.BackColor != Color.Blue)
                        item.BackColor = Color.Blue;
                    else
                        item.BackColor = Color.Green;
                }
                else if (item.ForeColor == Color.Blue)
                {
                    if (item.BackColor != Color.Yellow)
                        item.BackColor = Color.Yellow;
                    else
                        item.BackColor = Color.Orange;
                }
            }
        }
    }
}
