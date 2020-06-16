using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPencarianString
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

        private void tombolGo_Click(object sender, EventArgs e)
        {
            //Deklarasi variabel-variabel
            Int16 intIndeksAwal; //indeks awal pencarian
            Int16 intIndeksTemu; //indeks dari substring yang ditemukan

            //Menentukan apakah indeks awal numerik.
            
            if (ApaNumerik(teksIndeks.Text)) {
                //Menentukan apakah string pencarian telah dimasukkan.
                if (teksSubstring.Text.Length > 0) {
                    //Membaca indeks awal pencarian.
                    intIndeksAwal = Int16.Parse(teksIndeks.Text);
                    //Pencarian substring.
                    intIndeksTemu = (Int16) teksCari.Text.IndexOf(teksSubstring.Text, intIndeksAwal);
                    //Apakah substring yang dicari ditemukan
                    if (intIndeksTemu == -1)
                        teksHasil.Text = "Substring tidak ditemukan.";
                    else
                        teksHasil.Text = "Substring ditemukan pada indeks " + intIndeksTemu;
                }
                else 
                    //Menampilkan pesan error jika string kosong
                    MessageBox.Show("Masukkan string pencarian");
            }
            else
                //Menampilkan pesan error jika indeks non-numerik.
                MessageBox.Show("Indeks harus berupa angka.");
        }
    }
}