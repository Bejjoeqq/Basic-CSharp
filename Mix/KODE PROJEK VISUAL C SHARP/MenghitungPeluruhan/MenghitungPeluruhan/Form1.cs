using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenghitungPeluruhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTentukan_Click(object sender, EventArgs e)
        {
            double jumlah = 100;
            int tahun = 0;
            while (jumlah > 1)
            {
                jumlah = 0.5 * jumlah;
                tahun += 28;
            }
            teksKeluaran.Text = tahun + " tahun.";
        }
    }
}
