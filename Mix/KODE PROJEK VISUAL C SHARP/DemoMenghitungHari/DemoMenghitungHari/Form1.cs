using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMenghitungHari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolTentukan_Click(object sender, EventArgs e)
        {
            Int16 bulan, tahun, jumHari;
            
            bulan = Int16.Parse(teksBulanMasked.Text);
            tahun = Int16.Parse(teksTahunMasked.Text);

            switch (bulan) {
                case 9: //September
                case 4: //April
                case 6: //Juni
                case 11: //November
                    jumHari = 30;
                    break;
                case 2: //Pebruari
                    if (DateTime.IsLeapYear(tahun))
                        jumHari = 29;
                    else
                        jumHari = 28;
                    break;
                default:
                    jumHari = 31;
                    break;
            }
            teksKeluaran.Text = "Bulan " + bulan + " " + "pada tahun" + tahun +
                " memiliki " + jumHari + " hari.";
        }
    }
}
