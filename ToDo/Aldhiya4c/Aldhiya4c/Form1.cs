using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya4c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int x, y, j, k, ka, sisa;
            double b;

            x = Convert.ToInt16(txtX.Text);
            y = Convert.ToInt16(txtY.Text);

            j = x + y;
            k = x - y;
            ka = x * y;
            b = x / y;
            sisa = x % y;

            txtTambah.Text = Convert.ToString(j);
            txtKurang.Text = Convert.ToString(k);
            txtKali.Text = Convert.ToString(ka);
            txtBagi.Text = Convert.ToString(b);
            txtBulat.Text = Convert.ToString(sisa);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtBagi.Text = "";
            txtKali.Text = "";
            txtKurang.Text = "";
            txtBulat.Text = "";
            txtTambah.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
