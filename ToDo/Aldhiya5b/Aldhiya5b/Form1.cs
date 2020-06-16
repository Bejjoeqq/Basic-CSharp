using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya5b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int nilai;
            string hasil;

            nilai = Convert.ToInt16(cboNilai.Text);
             switch (hasil)
            {
                 case "A":
                    jurusan = "Rekayasa Perangkat Lunak";
                    stambuk = "2016";
                    nomor = "01";
                    break;
                case "165325":
                    jurusan = "Rekayasa Perangkat Lunak";
                    stambuk = "2016";
                    nomor = "02";
                    break;

            txtHasil.Text = Convert.ToString(hasil);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNilai.Text = "";
            txtHasil.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin mau keluar ?", "QUIT",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
