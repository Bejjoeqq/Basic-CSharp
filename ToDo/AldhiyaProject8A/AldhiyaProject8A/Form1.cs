using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaProject8A
{
    public partial class Form1 : Form
    {
        bool prima = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b,i;
            b = Convert.ToInt32(textBox1.Text);
            int temp = 0;
            for (i = Convert.ToInt32(textBox2.Text); i >= b; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        temp += 1;
                    }
                }
                if (temp == 2)
                {
                    listBox1.Items.Add(i + "");
                }
                temp = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
