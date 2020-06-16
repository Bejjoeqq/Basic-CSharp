using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya8B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int x, y, z;
        private void button3_Click(object sender, EventArgs e)
        {

            y =Convert.ToInt16(textBox1.Text);
            z = Convert.ToInt16(textBox2.Text);
            for (x = y; x <= z; x++)
            {
                listBox1.Items.Add(x);
            }

            x = y;
            while (x <= z)
            {
                listBox2.Items.Add(x);
                x++;
            }

            x = y;
            do
            {
                listBox3.Items.Add(x);
                x++;
            }
            while (x <= z);
        }
    }
}
