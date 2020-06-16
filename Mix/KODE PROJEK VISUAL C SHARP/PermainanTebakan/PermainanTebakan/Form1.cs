using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermainanTebakan
{
    public partial class Form1 : Form
    {
        Random angkaAcak = new Random((int)DateTime.Now.Ticks);
        int intAcak;
        int intTebakan = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public bool ApaNumerik(string masukan)
        {
            int uji;
            return int.TryParse(masukan, out uji);
        }

        private void tombolPermainan_Click(object sender, EventArgs e)
        {
            //membersihkan kotak list
            kotakListTebak.Items.Clear();

            //membangkitkan sebuah integer acak baru
            intAcak = angkaAcak.Next(1, 51);
            //menampilkan pada kotak list
            //kotakListTebak.Items.Add("Angka Acak: " + intAcak);
        }

        private void tombolTebak_Click(object sender, EventArgs e)
        {
            if (ApaNumerik(teksTebakAngka.Text)) {//apakah sebuah angka?
                //jika ya, lewatkan kepada variabel
                intTebakan = int.Parse(teksTebakAngka.Text);
                //memeriksa apakah berhasil
                Form1.ActiveForm.Text = "Tebakan saya: " + intTebakan;
                //membersihkan kotak teks dan menempatkan
                //kursor kembali ke kotak teks untuk tebakan berikutnya
                teksTebakAngka.Text = "";
                teksTebakAngka.Focus();
            }

            //jika angka sama dengan integer acak
            if (intTebakan == intAcak) {
                kotakListTebak.Items.Add("Selamat! Anda menemukannya!");
                kotakListTebak.Items.Add("Angka acak adalah " + intAcak);
            }
                //jika angka kurang dari integer acak
            else if (intTebakan < intAcak)
                kotakListTebak.Items.Add("Terlalu rendah!");
            else
                //jika angka lebih dari integer acak
                kotakListTebak.Items.Add("Terlalu tinggi!");
        }
     }
}
