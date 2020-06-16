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
        int kounter = 1;


        //Variabel-variabel global
        int[] arrayKu = new int[UKURAN_ARRAY];

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolUrutShell_Click(object sender, EventArgs e)
        {
            kotakList.Items.Add("=========ARRAY AWAL=========");
            MuatArray();
            TampilArray();
            kotakList.Items.Add("");

            kotakList.Items.Add("======PROSES PENGURUTAN======");
            PengurutanShell();
            kotakList.Items.Add("");

            kotakList.Items.Add("======HASIL PENGURUTAN======");
            TampilArray();
        }

        public void PengurutanShell()
        {
            int dalam, luar, temp;
            int h = 1;
            while (h <= arrayKu.Length / 3)
            {
                h = h * 3 + 1;
            }

            while (h > 0)
            {
                for (luar = h; luar < arrayKu.Length; luar++)
                {
                    temp = arrayKu[luar];
                    dalam = luar;
                    while ((dalam > (h - 1)) && (arrayKu[dalam - h] >= temp))
                    {
                        arrayKu[dalam] = arrayKu[dalam - h];
                        dalam -= h;
                    }
                    arrayKu[dalam] = temp;
                    //menampilkan tiap baris array pada kotak list
                    strArray = "";
                    for (int i = 0; i < arrayKu.Length; i++)
                    {
                        strArray += arrayKu[i] + " ";
                        kounter += 1;
                    }
                    kotakList.Items.Add("Inner " + dalam + ", Outer " + luar + ", " + strArray);
                }
                h = (h - 1) / 3;
            }
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