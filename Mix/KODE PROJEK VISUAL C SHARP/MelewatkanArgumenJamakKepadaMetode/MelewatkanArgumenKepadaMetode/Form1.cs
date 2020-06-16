using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelewatkanArgumenKepadaMetode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolDemo1_Click(object sender, EventArgs e)
        {
            //Event handler ini memanggil metode TampilNilai,
            //melewatkan 5 sebagai argumen
            kotakList.Items.Clear();
            TampilNilai(34, 573);
        }

        private void tombolDemo2_Click(object sender, EventArgs e)
        {
            //Memanggil metode TampilNilai beberapa kali,
            //melewatkan argumen-argumen yang berbeda pada tiap pemanggilan
            kotakList.Items.Clear();
            TampilNilai(5, 7);
            TampilNilai(10, 8);
            TampilNilai(2, 8);
            TampilNilai(16, 9);
            //Nilai dari sebuah ekspresi dilewatkan kepada
            //prosedur TampilNilai.
            TampilNilai(3, 5);
        }

        private void tombolDemo3_Click(object sender, EventArgs e)
        {
            //Menggunakan sebuah loop untuk memanggil metode TampilNilai
            //melewatkan sebuah variabel sebagai argumen
            kotakList.Items.Clear();

            for (int intHitung = 1; intHitung <= 10; intHitung++)
                TampilNilai(intHitung, intHitung);
        }

        private void TampilNilai(int intAngka1, int intAngka2)
        {
            int intJum; //variabel lokal untuk menyimpan hasil penjumlahan
            //Penjumlahan dari dua argumen
            intJum = intAngka1 + intAngka2;
            //Menempilkan penjumlahan pada kotak list
            kotakList.Items.Add("Hasil Penjumlahan: " + intAngka1.ToString() +
                "+" + intAngka2.ToString() + " = " + intJum.ToString());
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}