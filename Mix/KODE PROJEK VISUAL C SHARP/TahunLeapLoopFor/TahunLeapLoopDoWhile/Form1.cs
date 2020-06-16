using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahunLeapLoopDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolPeriksa_Click(object sender, EventArgs e)
        {
            try
            {
                Int16 tahun = Int16.Parse(teksTahun.Text);

                //Do while i kurang dari atau sama dengan 10
                for (int i = 0; i<100; i++)
                {
                    if (tahun < 0)
                    {
                        kotakList.Items.Add(tahun + " adalah tahun tidak valid!");
                        break;
                    }

                    if (((tahun % 4) == 0) && (((tahun % 100) != 0) || ((tahun % 400) == 0)))
                    {
                        kotakList.Items.Add(tahun + " adalah tahun Leap");
                    }
                    else
                        kotakList.Items.Add(tahun + " bukan tahun Leap");
                    tahun += 1;
                } 
            }
            catch
            {
                MessageBox.Show("Masukkan sedikitnya satu dijit");
            }
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
        }
    }
}