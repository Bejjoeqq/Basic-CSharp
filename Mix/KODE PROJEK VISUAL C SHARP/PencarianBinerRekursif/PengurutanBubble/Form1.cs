using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PengurutanBubble
{
    public partial class Form1 : Form
    {
        const int UKURAN_ARRAY = 30;
        int angkaAcak;


        //Variabel-variabel global
        int[] arrayKu = new int[UKURAN_ARRAY];

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolBinerRekursif_Click(object sender, EventArgs e)
        {
            kotakList.Items.Add("=========ARRAY AWAL=========");
            MuatArray();
            TampilArray();
            kotakList.Items.Add("");

            kotakList.Items.Add("====HASIL====");
            angkaAcak = pilihAngkaAcak();
            kotakList.Items.Add("Angka acak yang dicari adalah " + angkaAcak);

            pencarianBinerRekursif(angkaAcak, 0, arrayKu.Length - 1);
 
        }

        public void pencarianBinerRekursif(int nilai, int bawah, int atas)
        {
            if (bawah > atas)
                kotakList.Items.Add("Kesalahan Parameter Pencarian");
            else if (bawah < atas)
            {
                int tengah;
                tengah = (atas + bawah) / 2;

                if (nilai < arrayKu[tengah])
                    pencarianBinerRekursif(nilai, bawah, tengah - 1);
                else if (nilai == arrayKu[tengah])
                {
                    kotakList.Items.Add("Angka acak " + angkaAcak + " ada di dalam Array" +
                    " pada indeks " + tengah);
                }
                else
                    pencarianBinerRekursif(nilai, tengah + 1, atas);
            }
            else
                kotakList.Items.Add("Angka acak " + angkaAcak + " tidak ada di dalam Array");
        }

        private void TampilArray()
        {
            for (int i = 0; i < arrayKu.Length; i++)
            {
                kotakList.Items.Add(arrayKu[i]);
            }
        }

        private int pilihAngkaAcak()
        {
            int Min = 0;
            int Maks = 20;
            int angkaAcak;
            Random randNum = new Random();
            angkaAcak = randNum.Next(Min, Maks);
            return angkaAcak;

        }

        private int[] MuatArray()
        {
            int Min = 0;
            int Maks = 20;
            Random randNum = new Random();
            for (int i = 0; i < arrayKu.Length; i++)
            {
                arrayKu[i] = randNum.Next(Min, Maks);
            }

            return arrayKu;
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
        }
    }
}