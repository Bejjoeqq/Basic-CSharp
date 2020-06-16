using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoArrayParalel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTampil_Click(object sender, EventArgs e)
        {
            string[] strBulan = {"Januari", "Pebruari", "Maret",
                "April", "Mei", "Juni", "Juli", "Agustus", "September",
                "Oktober", "Nopember", "Desember"};

            //Array dengan jumlah hari pada tiap bulan
            int[] intHari = {31, 28, 31, 30, 31, 30,
                31, 31, 30, 31, 30, 31};

            //Menampilkan daftar bulan dan jumlah hari
            for(int i = 0; i < strBulan.Length; i++)
            {
                kotakList.Items.Add(strBulan[i] + " memiliki " +
                    intHari[i].ToString() + " hari.");
            }
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}