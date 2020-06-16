using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatuGuntingKertas
{
    public partial class Form1 : Form
    {
        int menang, kalah, seri;
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolMainkan_Click(object sender, EventArgs e)
        {
            //Membangkitkan angka acak
            Random TebakanKomputer = new Random((int)DateTime.Now.Ticks); 
            //Kode ini membangkitkan angka integer acak antara 1 dan 3,
            //jadi, hanya adalh tiga kemungkinan: 1, 2 dan 3
            //1 merepresentasikan Batu, 2 Gunting, dan 3 Kertas
            int intPilihanKomputer = 0;
            intPilihanKomputer = TebakanKomputer.Next(1, 4);

            if (RBBatu.Checked) {
            //Memeriksa apakah pengguna memiliki pilihan "Batu"
                switch(intPilihanKomputer) {
                //Memilih variabel "intPilihanKomputer" untuk dicocokkan
                    case 1: //Batu
                        MessageBox.Show("Pilihan Anda: Batu, Pilihan Komputer: Batu, Seri!!!.");
                        seri = seri + 1;
                        teksSeri.Text = seri.ToString();
                        break;
                    case 2: //Gunting
                        MessageBox.Show("Pilihan Anda: Batu, Pilihan Komputer: Gunting, Anda menang!.");
                        menang = menang + 1;
                        teksMenang.Text = menang.ToString();
                        break;
                    case 3: //Kertas
                        MessageBox.Show("Pilihan Anda: Batu, Pilihan Komputer: Kertas, Anda Kalah!");
                        kalah = kalah + 1;
                        teksKalah.Text = kalah.ToString();
                        break;
                    default:
                        MessageBox.Show("Error, sesuatu terjadi pada komputer");
                        break;
                }
            }

            if (RBGunting.Checked) {
            //Memeriksa apakah pengguna memiliki pilihan "Batu"
                switch(intPilihanKomputer) {
                //Memilih variabel "intPilihanKomputer" untuk dicocokkan
                    case 1: //Batu
                        MessageBox.Show("Pilihan Anda: Gunting, Pilihan Komputer: Batu, Anda Kalah!!!.");
                        kalah = kalah + 1;
                        teksKalah.Text = kalah.ToString();
                        break;
                    case 2: //Gunting
                        MessageBox.Show("Pilihan Anda: Gunting, Pilihan Komputer: Gunting, Seri!!!.");
                        seri = seri + 1;
                        teksSeri.Text = seri.ToString();
                        break;
                    case 3: //Kertas
                        MessageBox.Show("Pilihan Anda: Gunting, Pilihan Komputer: Kertas, Anda Menang!!!");
                        menang = menang + 1;
                        teksMenang.Text = menang.ToString();
                        break;
                    default:
                        MessageBox.Show("Error, sesuatu terjadi pada komputer");
                        break;
                }
            }

            if (RBKertas.Checked)
            //Memeriksa apakah pengguna memiliki pilihan "Batu"
                switch (intPilihanKomputer) {
                //Memilih variabel "intPilihanKomputer" untuk dicocokkan
                    case 1: //Batu
                        MessageBox.Show("Pilihan Anda: Kertas, Pilihan Komputer: Batu, Anda Menang!!!.");
                        menang = menang + 1;
                        teksMenang.Text = menang.ToString();
                        break;
                    case 2: //Gunting
                        MessageBox.Show("Pilihan Anda: Kertas, Pilihan Komputer: Gunting, Anda Kalah!!!.");
                        kalah = kalah + 1;
                        teksKalah.Text = kalah.ToString();
                        break;
                    case 3: //Kertas
                        MessageBox.Show("Pilihan Anda: Kertas, Pilihan Komputer: Kertas, Seri!!!");
                        seri = seri + 1;
                        teksSeri.Text = seri.ToString();
                        break;
                    default:
                        MessageBox.Show("Error, sesuatu terjadi pada komputer");
                        break;
                }
        }
    }
}
