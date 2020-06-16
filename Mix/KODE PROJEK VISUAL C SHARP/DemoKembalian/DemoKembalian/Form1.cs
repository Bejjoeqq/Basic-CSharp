using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoKembalian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            Double berat, biaya, uang, kembalian;
            berat = Double.Parse(teksBerat.Text);
            uang = Double.Parse(teksUang.Text);
            biaya = berat * 25000;

            if (uang >= biaya) {
                kembalian = uang - biaya;
                teksKeluaran.Text = "Kembalian Anda adalah " + "Rp. " +
                kembalian.ToString("N") + ".";
            }
            else {
                teksKeluaran.Text = "Saya perlu " + "Rp. " +
                (biaya - uang).ToString("N") + " lagi.";
            }
        }
    }
}
