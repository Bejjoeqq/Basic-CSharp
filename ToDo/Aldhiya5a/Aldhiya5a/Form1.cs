using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya5a
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
            nilai = Convert.ToInt16(txtNilai.Text);

            if (nilai > 75)
            {
                MessageBox.Show("Selamat Anda LULUS, Jangan Sombong");
            }
            else
            {
                MessageBox.Show("Anda GAGAL, Jangan Putus Asa");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNilai.Text = "";
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
