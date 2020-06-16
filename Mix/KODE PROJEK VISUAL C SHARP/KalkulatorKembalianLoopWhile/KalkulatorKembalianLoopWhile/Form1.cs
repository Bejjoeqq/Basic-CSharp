using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorKembalianLoopWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            int sngHargaBarang;
            int sngUangDibayar;
            int sngKembalian;
            int seratusRibu = 0;
            int limaPuluhRibu = 0;
            int duaPuluhRibu = 0;
            int sepuluhRibu = 0;
            int limaRibu = 0;
            int duaRibu = 0;
            int seRibu = 0;
            int limaRatus = 0;
            int seRatus = 0;

            sngHargaBarang = int.Parse(teksHarga.Text);
            sngUangDibayar = int.Parse(teksBayar.Text);
            sngKembalian = sngUangDibayar - sngHargaBarang;

            if (sngKembalian < 0)
                MessageBox.Show("Tidak ada uang kembalian minus");

            while (sngKembalian > 100) {
                if (sngKembalian > 99999) {
                    seratusRibu += 1;
                    sngKembalian = sngKembalian - 100000;
                }
                else if (sngKembalian > 49999) {
                    limaPuluhRibu += 1;
                    sngKembalian = sngKembalian - 50000;
                }
                else if (sngKembalian > 19999) {
                    duaPuluhRibu += 1;
                    sngKembalian = sngKembalian - 20000;
                }
                else if (sngKembalian > 9999) {
                    sepuluhRibu += 1;
                    sngKembalian = sngKembalian - 10000;
                }
                else if (sngKembalian > 4999) {
                    limaRibu += 1;
                    sngKembalian = sngKembalian - 5000;
                }
                else if (sngKembalian > 1999) {
                    duaRibu += 1;
                    sngKembalian = sngKembalian - 2000;
                }
                else if (sngKembalian > 999) {
                    seRibu += 1;
                    sngKembalian = sngKembalian - 1000;
                }
                else if (sngKembalian > 499) {
                    limaRatus += 1;
                    sngKembalian = sngKembalian - 500;
                }
                else if (sngKembalian > 99) {
                    seRatus += 1;
                    sngKembalian = sngKembalian - 100;
                }
            }

            teksSeratusRibu.Text = seratusRibu.ToString();
            teksLimaPuluhRibu.Text = limaPuluhRibu.ToString();
            teksDuaPuluhRibu.Text = duaPuluhRibu.ToString();
            teksSepuluhRibu.Text = sepuluhRibu.ToString();

            teksLimaRibu.Text = limaRibu.ToString();
            teksDuaRibu.Text = duaRibu.ToString();
            teksSeribu.Text = seRibu.ToString();
            teksLimaRatus.Text = limaRatus.ToString();
            teksSeratus.Text = seRatus.ToString();

            teksSisa.Text = sngKembalian.ToString();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

    }
}
