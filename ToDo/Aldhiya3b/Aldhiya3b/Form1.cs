using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya3b
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

        private void rdoKiri_CheckedChanged(object sender, EventArgs e)
        {
            txtTampil.TextAlign = HorizontalAlignment.Left;
        }

        private void rdoTengah_CheckedChanged(object sender, EventArgs e)
        {
            txtTampil.TextAlign = HorizontalAlignment.Center;
        }

        private void rdoKanan_CheckedChanged(object sender, EventArgs e)
        {
            txtTampil.TextAlign = HorizontalAlignment.Right;
        }

        private void chkPutih_CheckedChanged(object sender, EventArgs e)
        {
            txtTampil.BackColor = Color.White;
        }

        private void chkKuning_CheckedChanged(object sender, EventArgs e)
        {
            txtTampil.BackColor = Color.Yellow;
        }

        private void chkHijau_CheckedChanged(object sender, EventArgs e)
        {
            txtTampil.BackColor = Color.Green;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            txtTampil.Text = "";
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
