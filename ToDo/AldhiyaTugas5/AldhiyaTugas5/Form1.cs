using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaTugas5
{
    public partial class Form1 : Form
    {
        string kode, nama, bagian, jabatan, no;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            txtNama.Text = Convert.ToString(nama);
            txtBagian.Text = Convert.ToString(bagian);
            txtJabatan.Text = Convert.ToString(jabatan);
            txtNo.Text = Convert.ToString(no);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboKode.Text = " ";
            txtNama.Text = "";
            txtBagian.Text = "";
            txtJabatan.Text = "";
            txtNo.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboKode_SelectedIndexChanged(object sender, EventArgs e)
        {

            kode = Convert.ToString(cboKode.Text);

            switch (kode)
            {
                case "PM-A101":
                    nama = "Andi";
                    bagian = "Pemasaran";
                    jabatan = "Kepala Devisi";
                    no = "101";
                    break;
                case "PS-B201":
                    nama = "Budi";
                    bagian = "Personalia";
                    jabatan = "Staff";
                    no = "201";
                    break;
                case "KU-C301":
                    nama = "Andi";
                    bagian = "Keuangan";
                    jabatan = "Karyawan";
                    no = "301";
                    break;
                case "GD-A401":
                    nama = "Dodi";
                    bagian = "Gudang";
                    jabatan = "Kepala Devisi";
                    no = "401";
                    break;
                case "PM":
                    nama = "";
                    bagian = "Pemasaran";
                    jabatan = "";
                    no = "";
                    break;
                case"PS":
                    nama = "";
                    bagian = "Personalia";
                    jabatan = "";
                    no = "";
                    break;
                case"KU":
                    nama = "";
                    bagian = "Keuangan";
                    jabatan = "";
                    no = "";
                    break;
                case"GD":
                    nama = "";
                    bagian = "Gudang";
                    jabatan = "";
                    no = "";
                    break;
                case"A":
                    nama = "";
                    bagian = "";
                    jabatan="Kepala Devisi";
                    no = "";
                    break;
                case"B":
                    nama = "";
                    bagian = "";
                    jabatan = "Staff";
                    no = "";
                    break;
                case"C":
                    nama = "";
                    bagian = "";
                    jabatan = "Karyawan";
                    no = "";
                    break;
                case"101":
                    nama = "";
                    bagian = "";
                    jabatan = "";
                    no="101";
                    break;
                case"201":
                    nama = "";
                    bagian = "";
                    jabatan = "";
                    no = "201";
                    break;
                case"301":
                    nama = "";
                    bagian = "";
                    jabatan = "";
                    no = "301";
                    break;
                case"401":
                    nama = "";
                    bagian = "";
                    jabatan = "";
                    no="401";
                    break;
                case" ":
                    nama = "-";
                    bagian = "-";
                    jabatan = "-";
                    no = "-";
                    break;
            }
        }
    }
}
