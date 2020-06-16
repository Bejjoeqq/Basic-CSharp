using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NilaiMaksimum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTentukan_Click(object sender, EventArgs e)
        {
            Double angkaTerbesar = 0.0;
            if (Double.Parse(teksPertama.Text) > Double.Parse(teksKedua.Text))
                angkaTerbesar = Double.Parse(teksPertama.Text);
            else
                angkaTerbesar = Double.Parse(teksKedua.Text);

            teksNilaiMaks.Text = "Angka terbesar adalah: " + angkaTerbesar;
        }
    }
}
