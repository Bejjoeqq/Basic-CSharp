using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaTugasPraktekMDI
{
    public partial class KLingkaran : Form
    {
        public KLingkaran()
        {
            InitializeComponent();
        }
        double a = 3.14;
        double b, c;
        private void button1_Click(object sender, EventArgs e)
        {

            b = Convert.ToDouble(txts1.Text);

            c = 2 * a * b;


            txth1.Text = c.ToString();
        }
    }
}
