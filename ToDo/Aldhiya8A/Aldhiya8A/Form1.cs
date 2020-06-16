using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya8A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            for (x = 0; x <= 10; x++)
            {
                listBox1.Items.Add(x);
            }

            x = 0;
            while (x <= 10)
            {
                listBox2.Items.Add(x);
                x++;
            }

            x = 0;
            do
            {
                listBox3.Items.Add(x);
                x++;
            }
            while (x <= 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Text = "";
            listBox2.Text = "";
            listBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
