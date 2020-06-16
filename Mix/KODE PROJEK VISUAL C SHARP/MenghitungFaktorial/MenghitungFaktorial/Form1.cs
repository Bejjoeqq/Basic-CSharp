using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenghitungFaktorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            Int16 n;
            Int64 nfaktorial = 1;
            n = Int16.Parse(teksNilai.Text);

            if (n > 0) {
                for (int i = 1; i <= n; i++)
                    nfaktorial *= i;
                teksHasil.Text = nfaktorial.ToString();
            }
            else
                MessageBox.Show("Silahkan masukkan nilai > 0");
        }
    }
}
