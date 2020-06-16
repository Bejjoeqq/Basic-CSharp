using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Gate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Stop";
                x = 0;
            }
            else
            {
                button1.Text = "Start";
                label3.Text = "0";
                label4.Text = "0";
                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "";
                lbl4.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0")
            {
                label3.Text = "1";
            }
            else
            {
                label3.Text = "0";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "0")
            {
                label4.Text = "1";
            }
            else
            {
                label4.Text = "0";
            }
        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label3.Text=="1" && label4.Text == "1")
            {
                label2.Text = "1";
                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "";
                lbl4.Text = "1";
            }
            else if(label4.Text=="1" && label3.Text == "0")
            {
                label2.Text = "1";
                lbl1.Text = "";
                lbl2.Text = "1";
                lbl3.Text = "";
                lbl4.Text = "";
            }
            else if(label4.Text == "0" && label3.Text == "1")
            {
                label2.Text = "1";
                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "1";
                lbl4.Text = "";
            }
            else
            {
                label2.Text = "0";
                lbl1.Text = "0";
                lbl2.Text = "";
                lbl3.Text = "";
                lbl4.Text = "";
            }

            if (button1.Text == "Stop")
            {
                if (x == 0)
                {
                    label3.Text = "0";
                    label4.Text = "0";
                }
                if (x==10)
                {
                    label3.Text = "0";
                    label4.Text = "1";
                }
                if (x == 30)
                {
                    label3.Text = "1";
                    label4.Text = "0";
                }
                if (x == 50)
                {
                    label3.Text = "1";
                    label4.Text = "1";
                }
                if (x == 70)
                {
                    label3.Text = "0";
                    label4.Text = "0";
                    x = 0;
                }
                x++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
