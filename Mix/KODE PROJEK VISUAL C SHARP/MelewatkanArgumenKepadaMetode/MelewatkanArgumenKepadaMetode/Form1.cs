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
            TampilNilai(5);
        }

        private void tombolDemo2_Click(object sender, EventArgs e)
        {
            //Memanggil metode TampilNilai beberapa kali,
            //melewatkan argumen-argumen yang berbeda pada tiap pemanggilan
            kotakList.Items.Clear();
            TampilNilai(5);
            TampilNilai(10);
            TampilNilai(2);
            TampilNilai(16);
            //Nilai dari sebuah ekspresi dilewatkan kepada
            //prosedur TampilNilai.
            TampilNilai(3 + 5);
        }

        private void tombolDemo3_Click(object sender, EventArgs e)
        {
            //Menggunakan sebuah loop untuk memanggil prosedur TampilNilai
            //melewatkan sebuah variabel sebagai argumen
            kotakList.Items.Clear();

            for (int intHitung = 1; intHitung <= 10; intHitung++)
                TampilNilai(intHitung);
        }

        private void TampilNilai(int intAngka)
        {
            //Prosedur ini menambahkan sebuah nilai pada kotak list
            kotakList.Items.Add(intAngka.ToString());
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}