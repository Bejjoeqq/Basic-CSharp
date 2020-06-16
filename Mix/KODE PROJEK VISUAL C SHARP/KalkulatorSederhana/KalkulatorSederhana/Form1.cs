using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSederhana
{
    public partial class Form1 : Form
    {
        Double angka1;
        Double angka2;
        Double angkaJawaban;

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolKali_Click(object sender, EventArgs e)
        {
            angka1 = Double.Parse(teksAngka1.Text);
            angka2 = Double.Parse(teksAngka2.Text);
            angkaJawaban = angka1 * angka2;
            teksJawaban.Text = angkaJawaban.ToString();
            listJawaban.Items.Add(angka1 + " x " + angka2 + " = " + angkaJawaban);
        }

        private void tombolBagi_Click(object sender, EventArgs e)
        {
            angka1 = Double.Parse(teksAngka1.Text);
            angka2 = Double.Parse(teksAngka2.Text);
            angkaJawaban = angka1 / angka2;
            teksJawaban.Text = angkaJawaban.ToString();
            listJawaban.Items.Add(angka1 + " / " + angka2 + " = " + angkaJawaban);
        }

        private void tombolKurang_Click(object sender, EventArgs e)
        {
            angka1 = Double.Parse(teksAngka1.Text);
            angka2 = Double.Parse(teksAngka2.Text);
            angkaJawaban = angka1 - angka2;
            teksJawaban.Text = angkaJawaban.ToString();
            listJawaban.Items.Add(angka1 + " - " + angka2 + " = " + angkaJawaban);
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            angka1 = Double.Parse(teksAngka1.Text);
            angka2 = Double.Parse(teksAngka2.Text);
            angkaJawaban = angka1 + angka2;
            teksJawaban.Text = angkaJawaban.ToString();
            listJawaban.Items.Add(angka1 + " + " + angka2 + " = " + angkaJawaban);
        }
    }
}
