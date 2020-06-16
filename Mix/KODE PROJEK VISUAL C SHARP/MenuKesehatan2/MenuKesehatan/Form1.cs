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
        static int jum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkObat_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkObat.Checked)
                jum += 350000;
            else
                jum -= 350000;
            teksTotal.Text = "Rp. " + jum.ToString("N");
        }

        private void checkGigi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGigi.Checked)
                jum += 550000;
            else
                jum -= 550000;
            teksTotal.Text = "Rp. " + jum.ToString("N");
        }

        private void checkMata_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMata.Checked)
                jum += 750000;
            else
                jum -= 750000;
            teksTotal.Text = "Rp. " + jum.ToString("N");
        }

        private void checkKesehatan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKesehatan.Checked)
                jum += 1500000;
            else
                jum -= 1500000;
            teksTotal.Text = "Rp. " + jum.ToString("N");
        }
    }
}
