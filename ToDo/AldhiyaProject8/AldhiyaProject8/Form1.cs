using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaProject8
{
    public partial class Form1 : Form
    {
        int x, y, z;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            y = Convert.ToInt16(textBox1.Text);
            z = Convert.ToInt16(textBox2.Text);
            for (x = y; x >= z; x--)
            {
                listBox1.Items.Add(x);
            }

            x = y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            y = Convert.ToInt16(textBox1.Text);
            z = Convert.ToInt16(textBox2.Text);
            x = y;
            do
            {
                listBox2.Items.Add(x);
                x--;
            }
            while (x >= z);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            y = Convert.ToInt16(textBox1.Text);
            z = Convert.ToInt16(textBox2.Text);
            x = y;
            do
            {
                listBox3.Items.Add(x);
                x--;
            }
            while (x >= z);
        }
    }
}
