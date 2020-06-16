using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorBiayaKeanggotaan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool ApaNumerik(string masukan)
        {
            int uji;
            return int.TryParse(masukan, out uji);
        }


        private void tombolHitung_Click(object sender, EventArgs e)
        {
            Double decBulanan = 0.0; //Biaya bulanan
            Double decTotal; //biaya total
            Int16 intJumBulan = 0; //jumlah bulan
            Boolean blnMasukanOk = true;

            //Konstanta-konstanta
            const Double decBIAYA_DEWASA = 40000D;
            const Double decBIAYA_ANAK = 20000D;
            const Double decBIAYA_PELAJAR = 25000D;
            const Double decBIAYA_ORTU = 30000D;

            //Konstanta-konstanta opsi
            const Double decBIAYA_YOGA = 10000D;
            const Double decBIAYA_KARATE = 30000D;
            const Double decBIAYA_PELATIH = 50000D;

            //Memvalidasi dan mengkonversi
            teksStatus.Text = String.Empty;
            if (ApaNumerik(teksJumBulan.Text) == false) {
                teksStatus.Text = "Jumlah bulan harus integer.";
                blnMasukanOk = false;
            }

            intJumBulan = Int16.Parse(teksJumBulan.Text);
            // Memvalidasi jumlah bulan
            if ((intJumBulan < 1) || (intJumBulan > 24)) {
                teksStatus.Text = "Jumlah bulan harus dalam rentang 1 - 24.";
                blnMasukanOk = false;
            }

            if (blnMasukanOk == true) {
                //Menentukan biaya bulanan
                if (RBDewasa.Checked == true) 
                    decBulanan = decBIAYA_DEWASA;
                else if (RBANak.Checked == true)
                    decBulanan = decBIAYA_ANAK;
                else if (RBPelajar.Checked == true)
                    decBulanan = decBIAYA_PELAJAR;
                else if (RBOrtu.Checked == true)
                    decBulanan = decBIAYA_ORTU;

                //Memeriksa layanan tambahan
                if (CBYoga.Checked == true)
                    decBulanan += decBIAYA_YOGA;

                if (CBKarate.Checked == true)
                    decBulanan += decBIAYA_KARATE;

                if (CBPelatih.Checked == true)
                    decBulanan += decBIAYA_PELATIH;

                //Menghitung biaya total
                decTotal = decBulanan * intJumBulan;

                //Menampilkan biaya-biaya
                teksBiayaBulanan.Text = "Rp. " + decBulanan.ToString("N");
                teksTotal.Text = "Rp. " + decTotal.ToString("N");
            }
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            //Mereset tombol radio dewasa
            RBDewasa.Checked = true;

            //Menghapus kotak-kotak periksa
            CBYoga.Checked = false;
            CBKarate.Checked = false;
            CBPelatih.Checked = false;

            //Menghapus jumlah bulan
            teksJumBulan.Clear();

            //Menghapus kotak teks lainnya
            teksBiayaBulanan.Text = String.Empty;
            teksTotal.Text = String.Empty;
            teksStatus.Text = String.Empty;

            //Mengembalikan fokus pada teksJumBulan.
            teksJumBulan.Focus();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            //Menutup form
            Form1.ActiveForm.Close();
        }
    }
}
