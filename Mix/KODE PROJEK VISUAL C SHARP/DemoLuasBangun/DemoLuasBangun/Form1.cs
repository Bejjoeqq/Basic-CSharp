using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLuasBangun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            int nomorBangun;
            double radius, panjang, tinggi, lebar, luas;
            //pilihan masukan atas bangun dan dimensi-dimensinya
            //1. Lingkaran 2. Jajaran-genjang 3. Layang-layang
            nomorBangun = Int32.Parse(teksSeleksi.Text);

            switch(nomorBangun) {
                case 1:
                    teksPanjang.Clear();
                    teksTinggi.Clear();
                    teksLebar.Clear();
                    radius = Double.Parse(teksRadius.Text);
                    luas = 3.141593 * Math.Pow(radius, 2);
                    teksLuas.Text = luas.ToString();
                    break;
                case 2:
                    teksRadius.Clear();
                    teksLebar.Clear();
                    panjang = Double.Parse(teksPanjang.Text);
                    tinggi = Double.Parse(teksTinggi.Text);
                    luas = panjang * tinggi;
                    teksLuas.Text = luas.ToString();
                    break;
                case 3:
                    teksTinggi.Clear();
                    teksRadius.Clear();
                    panjang = Double.Parse(teksPanjang.Text);
                    lebar = Double.Parse(teksLebar.Text);
                    luas = panjang * lebar / 2;
                    teksLuas.Text = luas.ToString();
                    break;
}
        }
    }
}
