using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoOlimpiade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolEvaluasi_Click(object sender, EventArgs e)
        {
            Int16 posisi; //selektor
            posisi = Int16.Parse(teksPosisi.Text);
            switch(posisi) {
                case 1:
                    teksKeluaran.Text = "Peraih Medali Emas";
                    break;
                case 2:
                    teksKeluaran.Text = "Peraih Medali Perak";
                    break;
                case 3:
                    teksKeluaran.Text = "Peraih Medali Perunggu";
                    break;
                case 4:
                case 5:
                    teksKeluaran.Text = "Anda hampir memenangkan medali.";
                    break;
                default:
                    teksKeluaran.Text = "Terimakasih.";
                    break;
            }
            DateTime dt1;
            dt1.IsLeap
            

        }
    }
}


