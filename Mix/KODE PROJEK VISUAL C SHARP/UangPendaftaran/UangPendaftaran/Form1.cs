using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UangPendaftaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTentukan_Click(object sender, EventArgs e)
        {
            if (radioAnak.Checked)
                teksUang.Text = "Rp. " + (0).ToString("N");
            else if (radioMinor.Checked)
                teksUang.Text = "Rp. " + (5000).ToString("N");
            else if (radioDewasa.Checked)
                teksUang.Text = "Rp. " + (10000).ToString("N");
            else if (radioSenior.Checked)
                teksUang.Text = "Rp. " + (7500).ToString("N");
            else
                MessageBox.Show("Anda harus membuat pilihan.");
        }
    }
}
