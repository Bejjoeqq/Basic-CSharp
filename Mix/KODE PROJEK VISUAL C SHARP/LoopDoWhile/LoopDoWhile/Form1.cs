using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            //menghitung berapa tahun yang diperlukan untuk menjadi miliarder
            double saldo;
            int jumTahun = 0;
            saldo = double.Parse(teksSaldo.Text);

            do {
                saldo += 0.06 * saldo;
                jumTahun += 1;
            } while (saldo < 1000000000);

            teksKapan.Text = "Dalam " + jumTahun +
                " tahun Anda akan menjadi miliarder.";
        }
    }
}
