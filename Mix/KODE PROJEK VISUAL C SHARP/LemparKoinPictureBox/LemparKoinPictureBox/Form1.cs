using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemparKoinPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolLempar_Click(object sender, EventArgs e)
        {
            int intSisi; //Mengindikasikan sisi

            //Menginisialisasi pembangkit angka acak
            Random acak = new Random((int)DateTime.Now.Ticks);

            //Membaca angka acak dalam rentang 0-1
            //0 berarti ekor, 1 berarti kepala
            intSisi = acak.Next(2);

            //Menampilkan sisi yang berada di atas
            if (intSisi == 0) {
                //0 berarti ekor, jadi menampilkan ekor
                //citra kepala disembunyikan
                PB2.Visible = true;
                PB1.Visible = false;
            }
            else {
                //1 berarti kepala, jadi menampilkan kepala
                //citra ekor disembunyikan
                PB1.Visible = true;
                PB2.Visible = false;
            }
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}