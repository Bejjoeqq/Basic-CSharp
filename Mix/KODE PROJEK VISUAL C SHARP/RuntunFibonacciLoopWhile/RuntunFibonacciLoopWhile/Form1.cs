using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntunFibonacciLoopWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolJalankan_Click(object sender, EventArgs e)
        {
            Int64 angka1 = 0; //angka pertama
            Int64 angka2 = 1; //angka kedua
            Int64 jumAngka = 0; //penjumlahan atas angka pertama dan angka kedua
            Int64 angkaFib = Int64.Parse(teksAngka.Text);

            do { 
                //menambahkan dua angka pertama (0 dan 1)
                jumAngka = angka1 + angka2;
                //melewatkan angka2 kepada angka1
                angka1 = angka2;
                //melewatkan total (jumAngka) kepada angka2
                angka2 = jumAngka;
                kotakList.Items.Add(jumAngka.ToString());
            } while (jumAngka <= angkaFib);
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
        }
    }
}