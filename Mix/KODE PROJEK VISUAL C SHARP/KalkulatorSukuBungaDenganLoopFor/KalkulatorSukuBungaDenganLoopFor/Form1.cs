using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSukuBungaDenganLoopFor
{
    public partial class Form1 : Form
    {
        int intPeriodeBunga;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            teksInvestasi.Clear();
            teksBunga.Clear();
            teksJumTahun.Clear();
            kotakList.Items.Clear();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void RBTahun_CheckedChanged(object sender, EventArgs e)
        {
            intPeriodeBunga = 1;
            
        }

        private void RBBulan_CheckedChanged(object sender, EventArgs e)
        {
            intPeriodeBunga = 12;
        }

        private void RBMinggu_CheckedChanged(object sender, EventArgs e)
        {
            intPeriodeBunga = 52;
        }

        private void RBHari_CheckedChanged(object sender, EventArgs e)
        {
            intPeriodeBunga = 365;
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
            double sngInvestasi = double.Parse(teksInvestasi.Text);

            //berapa suku bunga
            double sngSukuBunga = double.Parse(teksBunga.Text);

            //Berapa banyak tahun
            int intJumTahun = int.Parse(teksJumTahun.Text);

            //total jumlah periode pembayaran
            int intPeriodePembayaran = intJumTahun * intPeriodeBunga;

            //suku bunga tiap periode pembayaran
            double sngSukuBungaPerPeriode = (sngSukuBunga / 100) / intPeriodeBunga;

            double sng_NilaiSekarang;

            for (int i = 1; i <= intPeriodePembayaran; i++) {
                 sng_NilaiSekarang = sngInvestasi * sngSukuBungaPerPeriode;
                sngInvestasi = sngInvestasi + sng_NilaiSekarang;
                kotakList.Items.Add(i + ": " + sngInvestasi.ToString("N"));
            }

            teksKeluaran.Text = "Anda mendapatkan Rp. " + sngInvestasi.ToString("N");
        }
    }
}
