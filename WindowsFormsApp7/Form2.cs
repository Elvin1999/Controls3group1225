using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            guna2CircleProgressBar1.Value += 1;
            guna2HtmlLabel1.Text = guna2CircleProgressBar1.Value.ToString();
            if(guna2CircleProgressBar1.Value > guna2CircleProgressBar1.Maximum)
            {
                timer.Stop();
            }
        }

        Timer timer = new Timer();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text=guna2RatingStar1.Value.ToString();
        }
    }
}
