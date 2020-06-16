using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemparDaduDenganLoopFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
                CBDadu.Items.Add(i);
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
            CBDadu.Items.Clear();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void tombolLempar_Click(object sender, EventArgs e)
        {
            int angkaAcak1;
            int angkaAcak2;

            //Menginisialisasi pembangkit angka acak
            Random rand1 = new Random((int)DateTime.Now.Second);
            Random rand2 = new Random((int)DateTime.Now.Ticks);

            //Menghitng angka acak antara 1 dan 6
            angkaAcak1 = rand1.Next(1,7);
            angkaAcak2 = rand2.Next(1,7);

            String simpan;
            int nilaiHenti;
            int dblKounter = 0;

            //mengosongkan kotak list
            //kotakList.Items.Clear();

            //mendapatkan nilai henti
            nilaiHenti = int.Parse(CBDadu.SelectedItem.ToString());

            //sekarang melempar dadu
            do {
                //Menghitng angka acak antara 1 dan 6
                angkaAcak1 = rand1.Next(1,7);
                angkaAcak2 = rand2.Next(1,7);

                //membuat string dan menambahkannya pada kotak list
                simpan = angkaAcak1.ToString() + " " + angkaAcak2.ToString();

                //memeriksa apakah double dan memodifikasi string
                //jika terjadi double, dan menghitungnya
                if (angkaAcak1 == angkaAcak2) {
                    simpan += " Double!";
                    dblKounter += 1;
                }

                //menyimpannya pada kotak list
                kotakList.Items.Add(simpan);
            }while ((angkaAcak1 == angkaAcak2) && (dblKounter == nilaiHenti));
        }
    }
}
