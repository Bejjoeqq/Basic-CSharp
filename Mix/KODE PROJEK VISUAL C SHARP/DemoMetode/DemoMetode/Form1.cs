using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMetode
{
    public partial class Form1 : Form
    {
        private int decRetail; //Menampung harga retail
        private int decPersen; //Menampung persen diskon

        public Form1()
        {
            InitializeComponent();
        }

        public bool ApaNumerik(string masukan)
        {
            int uji;
            return int.TryParse(masukan, out uji);
        }

        private bool ValidasiBidangMasukan() 
        {
            //Mengkonversi bidang masukan. Menghasilkan false jika
            //ada bidang tak-valid, dan menampilkan pesan error.
            if(ApaNumerik(teksHargaRetail.Text) == false) 
            {
                teksPesan.Text = "Harga retail harus numerik";
                return false;
            }
            decRetail = int.Parse(teksHargaRetail.Text);
            
            if(ApaNumerik(teksPersenDiskon.Text) == false) 
            {
                teksPesan.Text = "Persen diskon harus numerik";
                return false;
            }
            decPersen = int.Parse(teksPersenDiskon.Text);
            
            return true;
        }

        private int HitungHargaPenjualan(int decRetail, int decPersen)
        {
            //Menghitung dan menghasilkan harga penjualan
            int decHargaPenjualan;
            decHargaPenjualan = decRetail - (decRetail * decPersen / 100);
            return decHargaPenjualan;
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            int decHargaPenjualan;
            //Menghapus pesan sebelumnya
            teksPesan.Text = String.Empty;
            //Jika bidang masukan valid, menampilkan harga penjualan
            if (ValidasiBidangMasukan())
            {
                decHargaPenjualan = HitungHargaPenjualan(decRetail, decPersen);
                teksHargaPenjualan.Text = decHargaPenjualan.ToString("N");
            }
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
