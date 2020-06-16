using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PencarianBiner
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
            bool ditemukan;
            int n = 8;
            int[] list = {17, 21, 35, 43, 49, 57, 65, 78};
            string strList = "";

            // Menugaskan nilai-nilai list pada strList
            for (int i = 0; i < n; i++) strList += list[i] + "\r\n";

            // menampilkan list
            teksList.Text = strList;

            // Membaca target
            int target = int.Parse(teksTarget.Text);

            // Memproses target
            if (ApaNumerik(teksTarget.Text)) {
                ditemukan = PencarianBiner(list, n, target);
                if (ditemukan)
                    MessageBox.Show("DITEMUKAN! ");
                else
                    MessageBox.Show("TIDAK DITEMUKAN!");
            }
            else
                MessageBox.Show("Target tidak valid. Silahkan masukkan sebuah integer");
        }

        private bool PencarianBiner(int[] list, int n, int target) {
              // Mendeklarasikan bawah, tengah, dan atas
            int bawah = 0, tengah = 0, atas = n-1;

            // Loop pencarian biner
            while (bawah <= atas) {
                // Menghitung tengah
                tengah = (bawah + atas) / 2;

                // Memeriksa target terhadap list[tengah]
                if (target < list[tengah])
                    // Jika target di bawah list[tengah], reset atas
                    atas = tengah - 1;
                else if (target > list[tengah])
                    // Jika target di atas list[tengah], reset bawah
                    bawah = tengah + 1;
                else
                    // Jika target ditemukan, bawah ditetapkan untuk keluar loop
                    bawah = atas + 1;
            }
            // Menghasilkan true jika target ditemukan, dan false jika tidak ditemukan
            if (target == list[tengah])
                return true;
            else
                return false;
        }
    }
}
