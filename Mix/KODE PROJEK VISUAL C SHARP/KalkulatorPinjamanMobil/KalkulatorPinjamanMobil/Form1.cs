using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorPinjamanMobil
{
    public partial class Form1 : Form
    {
        //Konstanta-konstanta level-kelas
        const double dblJUM_BULAN = 12;   //Jumlah bulan setahun
        const double dblSUKU_BARU = 0.05; //Suku bunga untuk kendaraan baru
        const double dblSUKU_BEKAS = 0.08; //Suku bunga untuk kendaraan bekas
        
        //Variabel level-kelas untuk menampung suku bunga pertahun
        double dblBUNGA_PER_TAHUN = dblSUKU_BARU;

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            //Mereset suku bunga, membersihkan semua kotak teks,
            //dan kotak list. Menetapkan suku bunga default
            //untuk pinjaman kendaraan baru.
            RBBaru.Checked = true;
            dblBUNGA_PER_TAHUN = dblSUKU_BARU;
            kotakTeksBunga.Text = dblSUKU_BARU.ToString("p");
            kotakTeksHarga.Clear();
            kotakTeksUM.Clear();
            kotakTeksJumBulan.Clear();
            kotakList.Items.Clear();
            kotakTeksPesan.Clear();

            //Mereset fokus ke kotakTeksHarga
            kotakTeksHarga.Focus();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            //menutup form
            Form1.ActiveForm.Close();
        }

        private void RBBaru_CheckedChanged(object sender, EventArgs e)
        {
            //Jika tombol radio Baru diklik, maka
            //pengguna telah menyeleksi pinjaman kendaraan baru
            if (RBBaru.Checked == true)
            {
                dblBUNGA_PER_TAHUN = dblSUKU_BARU;
                kotakTeksBunga.Text = dblSUKU_BARU.ToString("p");
                kotakList.Items.Clear();
            }
        }

        private void RBBekas_CheckedChanged(object sender, EventArgs e)
        {
            //Jika tombol radio Bekas diklik, maka
            //pengguna telah menyeleksi pinjaman kendaraan bekas
            if (RBBekas.Checked == true)
            {
                dblBUNGA_PER_TAHUN = dblSUKU_BEKAS;
                kotakTeksBunga.Text = dblSUKU_BEKAS.ToString("p");
                kotakList.Items.Clear();
            }
        }

        public bool ApaNumerik(string masukan)
        {
            double uji;
            return double.TryParse(masukan, out uji);
        }

        public double IPmt(double bunga, int periodePembayaran, int jumPembayaran, double jumlah)
        {
            if (periodePembayaran < 1 || periodePembayaran > jumPembayaran)
                throw new ArgumentException("Periode Pembayaran harus antara 1 dan jumPembayaran");

            if (bunga == 0)
                throw new ArgumentException("Implementasi ini tidak menangani bunga nol");

            double pembayaran = Pmt(bunga, jumPembayaran, jumlah);
            double nilaiMasaDepan = FV(bunga, (periodePembayaran - 1), pembayaran, jumlah);
            return (nilaiMasaDepan * bunga);
        }

        public double Pmt(double bunga, int jumPembayaran, double jumlah)
        {
            double temp = System.Math.Pow((bunga + 1), jumPembayaran);
            return ((-jumlah * temp) / ((temp - 1)) * bunga);
        }

        public double FV(double bunga, int jumPembayaran, double pembayaran, double jumlah)
        {
            double temp = System.Math.Pow(bunga + 1, jumPembayaran);
            return ((-jumlah) * temp) - ((pembayaran / bunga) * (temp - 1));
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            double dblHargaKendaraan; //Harga kendaraan
            double dblUangMuka;       //Uang muka
            int intJumBulan;          //Jumlah bulan untuk pinjaman
            double dblPinjaman;       //Jumlah pinjaman
            double dblPembayaranBulanan; //Jumlah pembayaran bulanan
            double dblBunga;             //Bunga hutang yang dibayarkan pada periode tertentu
            int intHitung;               //Kounter untuk loop
            string strKeluaran; //digunakan untuk memuat sebaris keluaran
            bool blnInputOk = true;

            //Membaca biaya kendaraan
            dblHargaKendaraan = double.Parse(kotakTeksHarga.Text);
            if (ApaNumerik(kotakTeksHarga.Text)==false) {
                kotakTeksPesan.Text = "Harga kendaraan harus berupa angka";
                blnInputOk = false;
            }

            //Membaca uang muka
            dblUangMuka = double.Parse(kotakTeksUM.Text);
            if (ApaNumerik(kotakTeksUM.Text)==false) {
                kotakTeksPesan.Text = "Uang muka harus berupa angka";
                blnInputOk = false;
            }

            //Membaca jumlah bulan
            intJumBulan = int.Parse(kotakTeksJumBulan.Text);
            if (ApaNumerik(kotakTeksJumBulan.Text)==false) {
                kotakTeksPesan.Text = "Jumlah bulan harus integer";
                blnInputOk = false;
            }

            if (blnInputOk == true)
            {
                //Menghitung jumlah pinjaman dan pembayaran bulanan
                dblPinjaman = dblHargaKendaraan - dblUangMuka;
                dblPembayaranBulanan = Pmt(dblBUNGA_PER_TAHUN / dblJUM_BULAN,
                intJumBulan, -dblPinjaman);

                //Membersihkan kotak list dan kotakTeksPesan
                kotakList.Items.Clear();
                kotakTeksPesan.Clear();

                for (intHitung = 1; intHitung <= intJumBulan; intHitung++)
                {
                    //Menghitung jumlah bunga hutang untuk periode tertentu
                    dblBunga = IPmt(dblBUNGA_PER_TAHUN / dblJUM_BULAN,
                    intHitung, intJumBulan, -dblPinjaman);

                    //Mengawali string yang akan ditampilkan dengan Bulan
                    strKeluaran = "Bulan " + intHitung.ToString("d2");

                    //Menampilkan jumlah pembayaran
                    strKeluaran += "   : pembayaran = " +
                        dblPembayaranBulanan.ToString("n2");

                    //Menampilkan jumlah bunga
                    strKeluaran += ",    bunga = " + dblBunga.ToString("n2");

                    //Menampilkan string keluaran pada kotak list
                    kotakList.Items.Add(strKeluaran);
                }
            }
        }
    }
}