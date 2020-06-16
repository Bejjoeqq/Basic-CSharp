using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenghitungSisaHutang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolKapan_Click(object sender, EventArgs e)
        {
            double bungaPerBulan = double.Parse(teksBunga.Text);
            double bayarPerBulan = double.Parse(teksBayar.Text);
            double jumlahHutang = double.Parse(teksHutang.Text);
            int bulan = 0;

            double saldo = jumlahHutang;
            do
            {
                saldo = (1 + bungaPerBulan) * saldo - bayarPerBulan;
                bulan += 1;
            } while (saldo > jumlahHutang / 2);
            teksKeluaran.Text = bulan + " bulan.";
        }
    }
}