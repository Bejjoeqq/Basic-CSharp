using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PemanggilanMetode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TampilkanPesan()
        {
            //Ini merupakan prosedur untuk menampilkan pesan.
            kotakList.Items.Add("");
            kotakList.Items.Add("Ini dari metode TampilkanPesan().");
            kotakList.Items.Add("");
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void tombolTampil_Click(object sender, EventArgs e)
        {
            //Menampilkan teks pada kotak list
            kotakList.Items.Add("Ini dari metode tombolTampil_Click.");
            kotakList.Items.Add("Sekarang Saya memanggil metode TampilkanPesan().");
                
            //Memanggil prosedur TampilkanPesan
            TampilkanPesan();

            //Menampilkan teks kembali pada kotak list
            kotakList.Items.Add("Sekarang Saya kembali di prosedur tombolTampil_Click.");
        }
    }
}
