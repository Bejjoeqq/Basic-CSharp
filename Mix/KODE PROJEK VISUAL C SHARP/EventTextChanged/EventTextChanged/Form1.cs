using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTextChanged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool ApaNumerik(string masukan)
        {
            int uji;
            return int.TryParse(masukan, out uji);
        }

        private void teksNilai_TextChanged(object sender, EventArgs e)
        {
            if (ApaNumerik(teksNilai.Text) == false)
                MessageBox.Show("Silahkan Masukkan Angka...");
        }
    }
}
