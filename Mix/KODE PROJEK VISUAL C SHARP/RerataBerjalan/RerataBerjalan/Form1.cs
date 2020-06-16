using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RerataBerjalan
{
    public partial class Form1 : Form
    {
        Double nilai;
        Double nilaiRerata;
        Int16 kounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            try
            {
                nilai = Double.Parse(teksNilai.Text);
                nilaiRerata += nilai; //menambahkan nilai pada total
                kounter += 1;  //bertambah satu setiap kali tombolHitung diklik
                teksRerata.Text = "Rerata: " + (nilaiRerata / kounter);

                if (nilai < 50)
                    kotakList.Text = "Gagal";
                else if (nilai < 60)
                    kotakList.Text = "C";
                else if (nilai < 80)
                    kotakList.Text = "B";
                else if (nilai < 101)
                    kotakList.Text = "A";

                kotakList.Items.Add(nilai + " ==> " + kotakList.Text);
                teksNilai.Text = "";
            }
            catch
            {
                MessageBox.Show("Silahkan masukkan angka " + teksNilai.Text + " salah!!");
                teksNilai.Text = " ";
            }
        }
    }
}
