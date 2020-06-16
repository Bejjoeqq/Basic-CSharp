using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaftarTemanDariMasukanPengguna
{
    public partial class Form1 : Form
    {
        private List<string> daftarNama = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            //Menambahkan nama pada List
            daftarNama.Add(teksNama.Text);
            //Membersihkan kotak teks
            teksNama.Clear();
            teksNama.Focus();
        }

        private void tombolTampiltombolTampil_Click(object sender, EventArgs e)
        {
            //Menampilkan semua nama pada kotak list
            kotakList.Items.Clear();
            foreach(string strNama in daftarNama)
                kotakList.Items.Add(strNama); //Tambahkan pada kotak list
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
