using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MengimporFileTeksKeProgram
{
    public partial class Form1 : Form
    {
        string strpath;

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolIsiKotakTeks_Click(object sender, EventArgs e)
        {
            strpath = CBPath.Text;

            //Membersihkan data pada kotak teks
            kotakTeks.Clear();

            try
            {
                string nilai = File.ReadAllText(strpath);
                kotakTeks.Text = nilai;
            }

            catch 
            {
                MessageBox.Show("Periksa apakah nama file tepat");
            }
        }

        private void tombolIsiKotakList_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
            strpath = CBPath.Text;
            // Membuka file teks menggunakan statemen Using
            using (StreamReader SR = new StreamReader(strpath))
            {

                // Menyimpan isi pada String ini
                string baris;
            
                //Membaca baris pertama kemudian masuk ke loop
                baris = SR.ReadLine();

                //Menjelajah tiap baris pada file
                while (baris != null)
                {
                    kotakList.Items.Add(baris);
                    //Membaca baris berikutnya
                    baris = SR.ReadLine();
                }
            }
        }

        private void tombolSimpan_Click(object sender, EventArgs e)
        {
            string strpathkel = teksPath.Text;
            using (StreamWriter tulis = new StreamWriter(strpathkel))
            {
                 //untuk tiap item pada kotak list
                foreach (string item in kotakList.Items)
                {
                    tulis.WriteLine(item.ToString());

                }
                //for (int i = 0; i < kotakList.Items.Count; i++)
                 //   tulis.WriteLine(kotakList.GetItemText(kotakList.SelectedItem));
            }
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}