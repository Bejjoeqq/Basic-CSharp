using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonversiSuhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolKonversi_Click(object sender, EventArgs e)
        {
            Double suhuFah;
            Double suhuCel;

            suhuFah = Double.Parse(teksSuhu.Text);
            suhuFah = suhuFah - (32 * 5 / 9);
            suhuCel = Double.Parse(teksSuhu.Text);
            suhuCel = suhuCel * ((9 / 5) + 32);

            if (tombolRadio1.Checked)
                teksHasil.Text = teksSuhu.Text + " Fahrenheit sama dengan "
                    + suhuFah + " Celsius";
            else if (tombolRadio2.Checked)
                teksHasil.Text = teksSuhu.Text + " Celsius sama dengan " +
                suhuCel + " Fahrenheit";

        }
    }
}