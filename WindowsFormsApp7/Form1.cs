using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Download Completed");
            }
        }

        Timer timer=new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text=numericUpDown1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            redLbl.Text = $"Red : {redTrackBar.Value.ToString()}";
            greebLbl.Text = $"Green : {greenTrackBar.Value.ToString()}";
            blueLbl.Text = $"Blue : {blueTrackBar.Value.ToString()}";
            this.BackColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
