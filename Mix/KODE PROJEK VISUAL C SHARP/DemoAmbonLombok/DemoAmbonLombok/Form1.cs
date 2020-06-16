using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAmbonLombok
{
    public partial class Form1 : Form
    {
        //jumBaris memberitahu jumlah baris yang telah ditampilkan.
        Int16 jumBaris = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolAmbon_Click(object sender, EventArgs e)
        {
            if (jumBaris == 0) {
                listKeluaran.Items.Add("Ambon manise tanah yang elok.");
                jumBaris += 1;
            }
            else if (jumBaris == 2) {
                listKeluaran.Items.Add("Waktu hujan sore-sore.");
                jumBaris += 1;
            }
        }

        private void tombolLombok_Click(object sender, EventArgs e)
        {
            if (jumBaris == 1) {
                listKeluaran.Items.Add("Takjub dengan kemegahan alam senggigi.");
                jumBaris += 1;
            }
        }
    }
}
