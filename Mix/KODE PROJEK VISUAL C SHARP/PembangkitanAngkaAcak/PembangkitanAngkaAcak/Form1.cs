using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PembangkitanAngkaAcak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolBangkitkan_Click(object sender, EventArgs e)
        {
            int terbesar = 0;
            String strKeluaran = "";
            teksTerbesar.Text = "";
            int angkaAcak = 0;
            Random rand = new Random((int)DateTime.Now.Ticks);

            for (int kounter = 0; kounter< 15; kounter++) {
                angkaAcak = rand.Next(0,100);
                strKeluaran += angkaAcak + " ";

                // jika terbesar < angkaAcak, maka diganti
                if (terbesar < angkaAcak) terbesar = angkaAcak;
            }
            teksAcak.Text = strKeluaran;
            teksTerbesar.Text += terbesar;
        }
    }
}
