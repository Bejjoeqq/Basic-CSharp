using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKalkulatorLoopFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTabel_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
            int angkaAnda, pengali, jumBerjalan = 0;
            angkaAnda = int.Parse(teksAngka.Text);
            pengali = int.Parse(teksKali.Text);
            int jawaban;

            for (int i = 1; i <= pengali; i++)
            {
                jawaban = i * angkaAnda;
                kotakList.Items.Add(i + " X " + angkaAnda + " = " + jawaban);
                jumBerjalan = jumBerjalan + jawaban;
            }
            kotakList.Items.Add("Total " + jumBerjalan);
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}