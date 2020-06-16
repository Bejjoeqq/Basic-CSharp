using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoRerata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            Double s1, s2, s3;  //3 skor
            Double rerata;      //rerata dari dua skor tertinggi
            s1 = Double.Parse(teksSkor1.Text);
            s2 = Double.Parse(teksSkor2.Text);
            s3 = Double.Parse(teksSkor3.Text);

            if ((s1 <= s2) & (s1 <= s3))  //s1 nilai terkecil
                rerata = (s2 + s3) / 2;
            else if ((s2 <= s1) & (s2 <= s3))  //s2 nilai terkecil
                rerata = (s1 + s3) / 2;
            else
                rerata = (s1 + s2) / 2;

            teksRerata.Text = rerata.ToString();
        }
    }
}
