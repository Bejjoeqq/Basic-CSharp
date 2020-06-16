using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NilaiMaksdanMin
{
    public partial class Form1 : Form
    {
        Double nilai;
        Double nilaiRerata;
        Int16 kounter = 0;
        Double nilaiMaks;
        Double nilaiMin;

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            try {
                nilai = Double.Parse(teksNilai.Text);
                nilaiRerata += nilai; //menambahkan nilai pada total
                kounter += 1; //bertambah satu setiap kali tombolHitung diklik
                teksRerata.Text = "Rerata: " + nilaiRerata / kounter;

                if (kounter == 1) {
                    nilaiMaks = nilai; //hanya untuk pertama kali
                    nilaiMin = nilai;
                }
                
                if (nilai > nilaiMaks) //jika nilai lebih besar dari nilaiMaks
                    nilaiMaks = nilai; //memperbarui nilaiMaks

                teksMaks.Text = "Nilai Maksimum: " + nilaiMaks; //menampilkan

                if (nilai < nilaiMin) //jika nilai lebih kecil dari nilaiMin
                    nilaiMin = nilai; //memperbarui nilaiMin

                teksMin.Text = "Nilai Minimum: " + nilaiMin; //menampilkan

                if (nilai < 50)
                    kotakList.Text = "Gagal";
                else if (nilai < 60)
                    kotakList.Text = "C";
                else if (nilai < 80)
                    kotakList.Text = "B";
                else if (nilai < 101)
                    kotakList.Text = "A";

                kotakList.Items.Add(nilai + " ==> " + kotakList.Text);
                teksNilai.Text = " ";
            }
            catch {
                MessageBox.Show("Silahkan masukkan angka " + teksNilai.Text + " salah!!");
                teksNilai.Text = " ";
            }
        }
    }
}
