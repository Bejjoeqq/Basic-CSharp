using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PencarianSekuensial
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

        private void tombolCari_Click(object sender, EventArgs e)
        {
            // Mendeklarasikan variabel-variabel
            int[] arr = {34, 17, 62, 57, 9, 86, 45, 97, 29 };
            int target = int.Parse(teksTarget.Text); // nilai target
            if (ApaNumerik(teksTarget.Text))
                pencarianSekuensial(arr, target);
            else
                MessageBox.Show("Target tidak valid. Silahkan coba lagi.");
        }

        private void pencarianSekuensial(int[] arrayAngka, int target) {
            int i; // variabel kontrol loop
            int perbandingan; // jumlah perbandingan yang dilakukan
            string strLog = "CATATAN PENCARIAN SEKUENSIAL " + "\r\n";
            teksKeluaran.Text = ""; // Reset teksKeluaran
            const int UKURAN = 9;

            // Loop pencarian sekuensial
            for (i=0; i<UKURAN; i++) {
                strLog += "memeriksa lokasi " + i + " (" + arrayAngka[i] +")\r\n";
                if (target == arrayAngka[i]) break;
            }

            // Menentukan alasan mengapa loop keluar
            if (i < UKURAN) {
                strLog += target + " DITEMUKAN! ";
                perbandingan = i+1;
            }
            else {
                strLog += target + " TIDAK DITEMUKAN!";
                perbandingan = i;
            }

            // Menampilkan berapa banyak perbandingan yang telah dilakukan
            strLog += "\r\n" + perbandingan + " perbandingan dilakukan";
                teksKeluaran.Text = strLog;
        }
    }
}
