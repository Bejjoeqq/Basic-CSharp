using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatemenIfDenganAND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolNyalakan_Click(object sender, EventArgs e)
        {
            //Mendefinisikan 3 variabel untuk memuat kondisi-kondisi
            String strBaterei, strKunci, strBhnBakar;

            //Melewatkan data dalam ketiga kotak teks kepada variabel-variabel
            strBaterei = teksBaterei.Text;
            strKunci = teksKunci.Text;
            strBhnBakar = teksBahanBakar.Text;

            //Statemen If dengan AND untuk menyalakan mobil
            if ((strBaterei == "baterei") || (strBaterei == "Baterei") || (strBaterei == "ya") 
                && ((strKunci == "kunci") && (strBhnBakar == "bensin")))
                MessageBox.Show("Bummmmmm, Gas terus!!");
            else
                MessageBox.Show("Tidak bisa nyala ...");
        }
    }
}
