using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya6c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboNim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nim, stambuk, jurusan, nomor;
            nim = Convert.ToString(cboNim.Text);
            switch (nim)
            {
                case "165324":
                    jurusan = "Rekayasa Perangkat Lunak";
                    stambuk = "2016";
                    nomor = "01";
                    break;
                case "165325":
                    jurusan = "Rekayasa Perangkat Lunak";
                    stambuk = "2016";
                    nomor = "02";
                    break;
                default: stambuk = "2016";
                    jurusan = "Rekayasa Perangkat Lunak";
                    nomor = "00";
                    break;
            }
            txtJur.Text = Convert.ToString(jurusan);
            txtSta.Text = Convert.ToString(stambuk);
            txtNom.Text = Convert.ToString(nomor);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtJur.Text = "";
            txtNom.Text = "";
            txtSta.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
