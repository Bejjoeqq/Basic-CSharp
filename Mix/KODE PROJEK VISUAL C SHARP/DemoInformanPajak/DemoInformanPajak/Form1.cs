using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoInformanPajak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            double uangDiselamatkan, pembayaran = 0.0;
            uangDiselamatkan = Double.Parse(teksUang.Text);
            int pilihan = 0;
            if (uangDiselamatkan <= 75000000)
                pilihan = 1;
            if ((uangDiselamatkan > 75000000) && (uangDiselamatkan <= 100000000))
                pilihan = 2;
            if (uangDiselamatkan > 100000000)
                pilihan = 3;

            switch (pilihan) {
                case 1:
                    pembayaran = 0.1 * uangDiselamatkan;
                    break;
                case 2:
                    pembayaran = 7500000 + 0.05 * (uangDiselamatkan - 75000000);
                    break;
                case 3:
                    pembayaran = 8750000 + 0.01 * (uangDiselamatkan - 100000000);
                    if (pembayaran > 50000000)
                        pembayaran = 50000000;
                    break;
            }
            teksKeluaran.Text = "Rp. " + pembayaran.ToString("N");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
