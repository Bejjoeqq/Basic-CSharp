using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PembelianKomputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            if ((radDeluxe.Checked) || (radSuper.Checked))
            {
                Double biaya = 0;
                //menambah jumlah uang berdasarkan seleksi.
                if (radDeluxe.Checked)
                    biaya += 10000000;
                else //model super
                    biaya += 15000000;
                if (checkVideo.Checked)
                    biaya += 2000000;
                if (checkModem.Checked)
                    biaya += 300000;
                if (checkMemori.Checked)
                    biaya += 1200000;
                teksBiayaTotal.Text = "Rp. " + biaya.ToString("N");
            }
        }
    }
}
