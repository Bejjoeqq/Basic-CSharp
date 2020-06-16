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
        const int UKURAN_ARRAY = 20;
        int luar, dalam, temp;
        string strArray;


        //Variabel-variabel global
        int[] arrayKu = new int[UKURAN_ARRAY];

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolUrutSeleksi_Click(object sender, EventArgs e)
        {
            kotakList.Items.Add("=========ARRAY AWAL=========");
            MuatArray();
            TampilArray();
            kotakList.Items.Add("");

            kotakList.Items.Add("======PROSES PENGURUTAN======");
            PengurutanSeleksi();
            kotakList.Items.Add("");

            kotakList.Items.Add("======HASIL PENGURUTAN======");
            TampilArray();
        }

        public void PengurutanSeleksi()
        {
            //Loop luar bergerak dari elemen pertama ke elemen berikutnya sampai elemen terakhir
            for (luar = 0; luar < arrayKu.Length - 1; luar++)
            {
                //loop dalam bergerak dari elemen kedua array ke elemen terakhir,
                //mencari nilai-nilai yang lebih kecil dari elemen yang sedang ditunjuk oleh
                //loop luar. Pada tiap iterasi pada loop dalam, nilai yang paling minimum
                //pada array ditugaskan pada tempat yang sesuai.
                for (dalam = luar + 1; dalam < arrayKu.Length; dalam++)
                {
                    if (arrayKu[dalam] < arrayKu[luar]) 
                    {
                        //Ya lebih kecil, maka kedua angka saling ditukar
                        temp = arrayKu[luar];
                        arrayKu[luar] = arrayKu[dalam];
                        arrayKu[dalam] = temp;
                        TampilTukar();
                    }
                    TampilTanpaTukar();
                }
            }
        }

        private void TampilTanpaTukar()
        {
            //Menampilkan
            strArray = "";
            for (int i = 0; i < arrayKu.Length; i++)
            {
                strArray += arrayKu[i].ToString() + " ";
            }
            kotakList.Items.Add("Outer (" + luar + ") " + ", Inner (" + dalam + ") " +
                strArray + " " + arrayKu[luar].ToString() + " lebih kecil dari " +
            arrayKu[dalam].ToString());
        }

        private void TampilTukar()
        {
            //Menampilkan
            strArray = "";
            for (int i = 0; i < arrayKu.Length; i++)
                strArray += arrayKu[i].ToString() + " ";

            kotakList.Items.Add("Outer (" + luar + ") " + ", Inner (" + dalam + ") " +
                strArray + " " + arrayKu[dalam].ToString() + " lebih besar dari " +
            arrayKu[luar].ToString() + " Tukar!");
        }


        private void TampilArray()
        {
            for (int i = 0; i < arrayKu.Length; i++)
            {
                kotakList.Items.Add(arrayKu[i]);
            }
        }

        private int[] MuatArray()
        {
            int Min = 0;
            int Maks = 100;
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