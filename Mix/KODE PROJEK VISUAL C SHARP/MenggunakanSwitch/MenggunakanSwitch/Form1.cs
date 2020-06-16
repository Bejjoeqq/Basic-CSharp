using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenggunakanSwitch
{
    public partial class Form1 : Form
    {
        Int32 nilai;
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            nilai = Int32.Parse(teksNilai.Text);
            if (nilai < 50)
                kotakList.Text = "Gagal";
            else if (nilai < 60) 
                kotakList.Text = "C";
            else if (nilai < 80) 
                kotakList.Text = "B";
            else if (nilai < 101) 
                kotakList.Text = "A";

            kotakList.Items.Add(nilai + " ==> " + kotakList.Text);
        }

        private void tombolSwitch_Click(object sender, EventArgs e)
        {
            nilai = Int32.Parse(teksNilai.Text);
            bool evaluasi = (nilai > 0) && (nilai <= 50);

            switch (evaluasi)
            {
                case (true):
                    teksCase.Text = "Mengulang";
                    break;
                case (false):
                    teksCase.Text = "Lulus";
                    break;
            }
        }
    }
}
