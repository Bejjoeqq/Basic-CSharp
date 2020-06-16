using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoNilaiHuruf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolCari_Click(object sender, EventArgs e)
        {
            int skor, pilihan = 0;
            String nilaiHuruf;
            skor = int.Parse(teksNilaiNumerik.Text);
            if (skor >= 90)
                pilihan = 1;
            else if ((skor >= 80) && (skor < 90))
                pilihan = 2;
            else if ((skor >= 70) && (skor < 80))
                pilihan = 3;
            else if ((skor >= 60) && (skor < 70))
                pilihan = 4;
            else if ((skor >= 50) && (skor < 60))
                pilihan = 5;
            else
                pilihan = 6;

            switch(pilihan) {
                case 1:
                    nilaiHuruf = "A";
                    break;
                case 2:
                    nilaiHuruf = "B";
                    break;
                case 3:
                    nilaiHuruf = "C";
                    break;
                case 4:
                    nilaiHuruf = "D";
                    break;
                case 5:
                    nilaiHuruf = "F";
                    break;
                default:
                    nilaiHuruf = "Tidak Valid";
                    break;
            }
            teksKeluaran.Text = "Huruf nilai adalah " + nilaiHuruf + ".";
        }
    }
}
