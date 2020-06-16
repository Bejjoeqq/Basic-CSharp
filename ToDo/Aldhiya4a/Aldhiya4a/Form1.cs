using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya4a
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

        private void btnProses_Click(object sender, EventArgs e)
        {
            int panjang, lebar, hasil;
            panjang = Convert.ToInt16(txtPanjang.Text);
            lebar = Convert.ToInt16(txtLebar.Text);
            
            hasil = panjang * lebar;
            txtHasil.Text = Convert.ToString(hasil);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPanjang.Text = "";
            txtLebar.Text = "";
            txtHasil.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {
            txtHasil.Enabled = false;
        }
    }
}
