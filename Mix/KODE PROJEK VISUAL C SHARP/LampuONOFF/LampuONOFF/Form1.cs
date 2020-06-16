using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LampuONOFF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void tombolSaklar_Click(object sender, EventArgs e)
        {
            //Membalik status lampu
            if (PBLampuOFF.Visible == true)
                LampuON();
            else
                LampuOFF();
        }

        private void LampuON()
        {
            //Menampilkan citra "LampuON"
            PBLampuOFF.Visible = false;
            //Menyembunyikan citra "LampuOFF"
            PBLampuON.Visible = true;
            //Mengubah teks label
            statusLampu.Text = "ON";
        }

         private void LampuOFF()
         {
            //Menampilkan citra "LampuFF"
            PBLampuON.Visible = false;
            //Menyembunyikan citra "LampuON"
            PBLampuOFF.Visible = true;
            //Mengubah teks label
            statusLampu.Text = "OFF";
         }
    }
}
