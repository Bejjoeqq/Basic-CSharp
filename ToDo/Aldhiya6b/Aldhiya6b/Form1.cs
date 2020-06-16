using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya6b
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
            string konver;
            string ket;

            nilai = Convert.ToInt16(txtNilai.Text);

            if (nilai > 85)
            {
                konver = "A";
            }
            else if (nilai > 75)
            {
                konver = "B";
            }
            else if (nilai > 65)
            {
                konver = "C";
            }
            else if (nilai > 55)
            {
                konver = "D";
            }
            else
            {
                konver = "E";
            }

            switch (konver)
            {
                case "A": ket = "LULUS"; break;
                case "B": ket = "LULUS"; break;
                case "C": ket = "GAGAL"; break;
                case "D": ket = "GAGAL"; break;
                case "E": ket = "GAGAL"; break;
                default: ket = "Pilihan Salah"; break;
            }
            txtHasil.Text = Convert.ToString(konver);
            txtKet.Text = Convert.ToString(ket);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHasil.Text = "";
            txtKet.Text = "";
            txtNilai.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
