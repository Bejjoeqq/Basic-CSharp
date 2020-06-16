using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemilihTanggal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTampil_Click(object sender, EventArgs e)
        {
            DateTime dt1, dt2;
            dt1 = DTP1.Value;
            dt2 = DTP2.Value;
            if (dt1 > dt2)
            {
                teksHasil.Text = "Anda memilih tanggal pertama lebih muda dari tanggal kedua. ";
                teksHasil.Text += "Selisih hari tanggal kedua dari tanggal pertama adalah " +
                (dt2.Subtract(dt1)).Days.ToString() + " hari.";
            }
            else if (dt1 < dt2)
            {
                teksHasil.Text = "Anda memilih tanggal pertama lebih tua dari tanggal kedua. ";
                teksHasil.Text += "Selisih hari tanggal kedua dari tanggal pertama adalah " +
                (dt2.Subtract(dt1)).Days.ToString() + " hari.";
            }
            else
            {
                teksHasil.Text = "Kedua tanggal yang Anda pilih sama.";
            }
        }
    }
}
