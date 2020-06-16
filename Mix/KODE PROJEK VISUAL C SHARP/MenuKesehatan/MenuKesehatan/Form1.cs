using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuKesehatan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTentukan_Click(object sender, EventArgs e)
        {
            int jum = 0;
            if (checkObat.Checked)
                jum += 350000;
            if (checkGigi.Checked)
                jum += 550000;
            if (checkMata.Checked)
                jum += 750000;
            if (checkKesehatan.Checked)
                jum += 1500000;
            teksTotal.Text = "Rp. " + jum.ToString("N");
        }
    }
}
