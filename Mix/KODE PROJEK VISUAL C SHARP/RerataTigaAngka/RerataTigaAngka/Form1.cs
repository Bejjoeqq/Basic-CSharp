using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RerataTigaAngka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            //Variabel-variabel untuk menampung data
            Double dblSkor1 = 0.0;
            Double dblSkor2 = 0.0;
            Double dblSkor3 = 0.0;
            Double dblRerata = 0.0;

            //Konstanta-konstanta
            const Int16 JUM_SKOR = 3;
            const Double dblSKOR_TINGGI = 95.0;

            //Salin ketiga skor pada kotak teks ke dalam variabel-variabel.
            dblSkor1 = Double.Parse(teksSkor1.Text);
            dblSkor2 = Double.Parse(teksSkor2.Text);
            dblSkor3 = Double.Parse(teksSkor3.Text);

            //Menghitung skor rerata.
            dblRerata = (dblSkor1 + dblSkor2 + dblSkor3) / JUM_SKOR;

            //Menampilkan rerata, membulatkannya menjadi 2 dijit di belakang desimal.
            teksRerata.Text = dblRerata.ToString("n2");

            //Jika skor tinggi, berikan pujian.
            if (dblRerata > dblSKOR_TINGGI)
                labelPesan.Text = "Selamat! Kerja keras membuahkan hasil!";
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            teksSkor1.Text = "";
            teksSkor2.Text = "";
            teksSkor3.Text = "";
            teksRerata.Text = "";
            labelPesan.Text = "";
        }

    }
}
