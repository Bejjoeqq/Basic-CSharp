using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya7a
{
    public partial class Form1 : Form
    {
        string status, status1, h;
        double jlebar, harga, biaya, kembali, bayar;
        public Form1()
        {
            MessageBox.Show("Welcome To Bejjo Photo Copy");
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            status = Convert.ToString(cboStatus.Text);
            jlebar = Convert.ToInt16(txtJumlah.Text);
            switch (status)
            {
                case "Member":
                    harga = 100;
                    biaya = jlebar * harga;
                    break;
                case "Non Member":
                    if (jlebar > 100)
                    {
                        harga = 125;
                        biaya = jlebar * harga;
                    }
                    else
                    {
                        harga = 150;
                        biaya = jlebar * harga;
                    }
                    break;
                default:
                    break;
            }
            txtBiaya.Text = Convert.ToString(biaya);
            txtPembayaran.Enabled = true;
            lblBayar.Text = "<- Masukkan Jumlah Uang Anda";
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            string a, b, c;
            bayar = Convert.ToDouble(txtPembayaran.Text);
            kembali = bayar - biaya;
            a = "Kembalian anda Rp"+Convert.ToString(kembali);
            b = "Uang Anda Kurang Rp" + Convert.ToString(kembali);
            if (kembali <= 0)
            {
                txtKembali.Text = Convert.ToString(kembali);
                MessageBox.Show(Convert.ToString(b),"Uang Anda Kurang");
            }
            else
            {
                txtKembali.Text = Convert.ToString(kembali);
                MessageBox.Show(Convert.ToString(a),"Terima Kasih");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBiaya.Text = "";
            txtHarga.Text = "";
            txtJumlah.Text = "";
            txtKembali.Text = "";
            txtPembayaran.Text = "";
            cboStatus.Text = "";
            lblJumlah.Text = "";
            lblBayar.Text = "";
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

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status1 = Convert.ToString(cboStatus.Text);
            switch (status1)
            {
                case "Member":
                    h = "100/Lembar";
                    break;
                case "Non Member":
                    h = "125/Lembar Jika Lembar>100 Jika Tidak 150/Lembar";
                    break;
            }
            txtHarga.Text = Convert.ToString(h);
            txtJumlah.Enabled = true;
            lblJumlah.Text = "<- Masukkan Jumlah Lembar";
        }
    }
}
