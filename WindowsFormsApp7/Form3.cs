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
    public partial class Form3 : Form
    {
        public List<Student> Students { get; set; }
        public Form3()
        {
            InitializeComponent();
            Students = new List<Student>
            {
                new Student
                {
                    Name="John",
                    Surname="Johnlu",
                    Age=32
                },
                new Student
                {
                    Name="Leyla",
                    Surname="Leylali",
                    Age=55
                },
                new Student
                {
                    Name="Tural",
                    Surname="Eliyev",
                    Age=33
                }
            };



            int y = 0;
            foreach (var student in Students)
            {
                var uc = new StudentUC();
                uc.Name = student.Name;
                uc.Surname = student.Surname;
                uc.Age = student.Age;   

                uc.Location = new Point(0, y);
                y += 100;
                this.Controls.Add(uc);
            }

        }

        UserControl1 userControl1 = new UserControl1();
        UserControl2 userControl2 = new UserControl2();
        private void Form3_Load(object sender, EventArgs e)
        {
            //userControl1.Location = new Point(50, 50);
            //this.Controls.Add(userControl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(userControl1);
            userControl2.Location = new Point(50, 50);
            this.Controls.Add(userControl2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(userControl2);
            userControl2 = new UserControl2();
            userControl1.Location = new Point(50, 50);
            this.Controls.Add(userControl1);
        }
    }
}
