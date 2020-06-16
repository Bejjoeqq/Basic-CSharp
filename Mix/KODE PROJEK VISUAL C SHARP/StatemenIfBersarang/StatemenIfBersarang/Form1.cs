using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatemenIfBersarang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolPeriksa_Click(object sender, EventArgs e)
        {
            //Variabel-variabel untuk menampung data masukan.
            Double dblGaji;
            Int64 intTahunKerja;

            //Membaca masukan pengguna
            dblGaji = Double.Parse(teksGajiPerTahun.Text);
            intTahunKerja = Int64.Parse(teksJumThnKerja.Text);

            //Menentukan apakah aplikan memenuhi kualifikasi
            //untuk pinjaman tertentu
            if (dblGaji > 30000000)
                if (intTahunKerja > 2) 
                    teksKualifikasi.Text = "Aplikan" +
                        " memenuhi kualifikasi untuk meminjam.";
                else
                    teksKualifikasi.Text = "Aplikan " +
                        "tidak memenuhi kualifikasi untuk meminjam.";
            else
                if (intTahunKerja > 5)
                    teksKualifikasi.Text = "Aplikan" +
                        " tidak memenuhi kualifikasi untuk meminjam.";
                else
                    teksKualifikasi.Text = "Aplikan" +
                        " memenuhi kualifikasi untuk meminjam.";

        }
    }
}
