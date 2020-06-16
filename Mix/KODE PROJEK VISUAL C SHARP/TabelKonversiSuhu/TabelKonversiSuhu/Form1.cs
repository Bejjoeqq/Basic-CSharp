using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelKonversiSuhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTampilkan_Click(object sender, EventArgs e)
        {
            double Celcius = 10;
            listKeluaran.Items.Add("Celcius    Fahrenheit");
            do
            {
                listKeluaran.Items.Add("    " + Celcius + "            " + Fahrenheit(Celcius));
                Celcius += 5;
            } while (Celcius <= 100);
        }

        private double Fahrenheit(double Celcius) {
            //mengkonversi Celcius ke Fahrenheit
            return (9 / 5) * Celcius + 32;
        }
    }
}
