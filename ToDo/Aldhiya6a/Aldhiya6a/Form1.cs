using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya6a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            string huruf, hasil;

            huruf = Convert.ToString(txtHuruf.Text);

            switch (huruf)
            {
                case "A": hasil = "4"; break;
                case "B": hasil = "3"; break;
                case "C": hasil = "2"; break;
                case "D": hasil = "1"; break;
                case "E": hasil = "0"; break;
                default: hasil = "Pilihan Salah"; break;
            }
            txtNilai.Text = Convert.ToString(hasil);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNilai.Text = "";
            txtHuruf.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
