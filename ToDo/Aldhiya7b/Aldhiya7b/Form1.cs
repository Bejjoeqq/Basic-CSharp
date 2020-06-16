using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya7b
{
    public partial class Form1 : Form
    {
        string kodepegawai, nama, bagian, jabatan, status;
        double gapok, jlhanak, totalgaji;
        double pajak, tunjangananak, tunjangankeluarga;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            kodepegawai = Convert.ToString(cboKode.Text);
            jabatan = Convert.ToString(cboJabatan.Text);

            switch (kodepegawai)
            {
                case "PM101":
                    nama = "Andi";
                    bagian = "Pemasaran";
                    break;
                case "PS201":
                    nama = "Budi";
                    bagian = "Pemasaran";
                    break;
                case "KU301":
                    nama = "Cici";
                    bagian = "Keuangan";
                    break;
                default:
                    nama = "Dodi";
                    bagian = "Gudang";
                    break;
            }
            txtNama.Text = Convert.ToString(nama);
            txtBagian.Text = Convert.ToString(bagian);
        }

        private void cboJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJabatan.Text == "Kepala Devisi")
            {
                gapok = 5000000;
            }
            else if (cboJabatan.Text == "Staff")
            {
                gapok = 3500000;
            }
            else
            {
                gapok = 2000000;
            }
            pajak = 0.05 * gapok;
            txtGaji.Text = Convert.ToString(gapok);
            txtPajak.Text = Convert.ToString(pajak);
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = Convert.ToString(cboStatus.Text);
            if (status == "Menikah")
            {
                tunjangankeluarga = 0.15 * gapok;
                cboAnak.Enabled = true;
                
            }
            else if(status == "Belum Menikah")
            {
                tunjangankeluarga = 0.00 * gapok;
                cboAnak.Enabled = false;
            }
            txtKeluarga.Text = Convert.ToString(tunjangankeluarga);
        }

        private void cboAnak_SelectedIndexChanged(object sender, EventArgs e)
        {
            jlhanak = Convert.ToInt16(cboAnak.Text);
            if (jlhanak == 3)
            {
                tunjangananak = 0.15 * gapok;
            }
            else if (jlhanak == 2)
            {
                tunjangananak = 0.1 * gapok;
            }
            else if (jlhanak == 1)
            {
                tunjangananak = 0.05 * gapok;
            }
            txtAnak.Text = Convert.ToString(tunjangananak);
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            totalgaji = gapok - pajak + tunjangankeluarga + tunjangankeluarga;
            txtTotal.Text = Convert.ToString(totalgaji);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboAnak.Text = "";
            cboJabatan.Text = "";
            cboKode.Text = "";
            cboStatus.Text = "";
            txtAnak.Text = "";
            txtBagian.Text = "";
            txtGaji.Text = "";
            txtKeluarga.Text = "";
            txtNama.Text = "";
            txtPajak.Text = "";
            txtTotal.Text = "";
        }
    }
}
