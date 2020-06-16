using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiBiroTravelSederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            Int16 kamar;
            int malam;
            double biaya;
            double diskon = 0.0;
            double total;
            DateTime tiba;
            DateTime pulang;
            bool ok = true;

            // Membaca data dari kontrol-kontrol masukan
            kamar = Int16.Parse(komboKamar.SelectedItem.ToString());
            tiba = kalenderTiba.SelectionStart;
            pulang = kalenderPulang.SelectionStart;

            if (tombolToba.Checked == true)
                biaya = 2500000;
            else if ((tombolSenggigi.Checked == true) ||
                    (tombolJogja.Checked == true))
                biaya = 2000000;
            else
                biaya = 3000000;

            // Memeriksa apakah kamar invalid
            if (kamar <= 0) {
                MessageBox.Show("Anda harus memasukkan kamar dengan benar.");
                ok = false;
            }

            // Menghitung berapa malam menginap
            malam = (pulang - tiba).Days;

            // Memeriksa apakah malam tidak valid
            if (malam <= 0) {
                MessageBox.Show("Anda harus memilih tanggal pulang setelah tanggal tiba.");
                ok = false;
            }

            // Memproses data valid
            if (ok)
            {
                switch (kamar)
                {
                    case 1: diskon = 0; break;
                    case 2: diskon = 200000; break;
                    case 3: diskon = 250000; break;
                    case 4: diskon = 350000; break;
                    case 5:
                    case 6: diskon = 500000; break;
                }
                total = kamar * malam * (biaya - diskon);
                teksBiaya.Text = "Rp. " + total.ToString();
            }
        }
    }
}
