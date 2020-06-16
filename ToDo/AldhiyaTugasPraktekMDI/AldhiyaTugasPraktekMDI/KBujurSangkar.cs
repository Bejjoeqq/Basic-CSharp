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
    public partial class KBujurSangkar : Form
    {
        public KBujurSangkar()
        {
            InitializeComponent();
        }
        double a, b, c;
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txts1.Text);
            b = Convert.ToDouble(txts2.Text);

            c = a + a + b + b;

            txth1.Text = c.ToString();
        }
    }
}
