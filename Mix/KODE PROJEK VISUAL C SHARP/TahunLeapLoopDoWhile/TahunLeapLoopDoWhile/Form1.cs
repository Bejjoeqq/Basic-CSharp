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
            Int16 tahun = Int16.Parse(teksTahun.Text);
            int i = 1;

            //Do while i kurang dari atau sama dengan 10
            do { 
                if (((tahun % 4) == 0) && (((tahun % 100) != 0) || ((tahun % 400) == 0)))  {
                    kotakList.Items.Add(tahun + " adalah tahun Leap");
                    i += 1;
                }
                else 
                    kotakList.Items.Add(tahun + " bukan tahun Leap");
            tahun += 1;
            }while (i <= 100);
        }
    }
}