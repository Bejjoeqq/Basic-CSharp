using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            const double phi = 3.14;
            double jari, luas;

            jari = Convert.ToInt16(txtJari.Text);
            luas = phi * jari * jari;
            txtHasil.Text = Convert.ToString(luas);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtJari.Text = "";
            txtHasil.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
