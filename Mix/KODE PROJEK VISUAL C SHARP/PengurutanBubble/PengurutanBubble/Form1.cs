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
        int kounter = 1;
        string strArray;

        //Variabel-variabel global
        int[] arrayKu = new int[UKURAN_ARRAY];

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolUrutBubble_Click(object sender, EventArgs e)
        {
            kotakList.Items.Add("=========ARRAY AWAL=========");
            MuatArray();
            TampilArray();
            kotakList.Items.Add("");

            kotakList.Items.Add("======PROSES PENGURUTAN======");
            PengurutanBubble1();
            kotakList.Items.Add("");

            kotakList.Items.Add("======HASIL PENGURUTAN======");
            TampilArray();
        }


        private void PengurutanBubble1()
        {
            int luar, dalam, temp;
            for (luar = arrayKu.Length - 1; luar > 0; luar--)
            {
                for (dalam = 0; dalam < luar; dalam++)
                {
                    //jika angka pertama lebih besar dari angka kedua
                    if (arrayKu[dalam] > arrayKu[dalam + 1]) 
                    {
                        //maka melewatkan angka pertama kepada temp
                        temp = arrayKu[dalam];
                        //angka kedua menggantikan angka pertama
                        arrayKu[dalam] = arrayKu[dalam + 1];
                        //menggeser angka pertama untuk menempati angka kedua
                        arrayKu[dalam + 1] = temp;
                    }
                    //menampilkan tiap baris array pada kotak list
                    strArray = "";
                    for (int i = 0; i <arrayKu.Length; i++)
                    {
                        strArray += arrayKu[i].ToString() + " ";
                        kounter += 1;
                    }
                    kotakList.Items.Add("Inner " + dalam + ", Outer " + luar + ", " + strArray);
                }
            }
        }

        private void PengurutanBubble2()
        {
            int temp = 0;
            for (int tulis = 0; tulis < arrayKu.Length; tulis++)
            {
                for (int urut = 0; urut < arrayKu.Length - 1; urut++)
                {
                    if (arrayKu[urut] > arrayKu[urut + 1])
                    {
                        temp = arrayKu[urut + 1];
                        arrayKu[urut + 1] = arrayKu[urut];
                        arrayKu[urut] = temp;
                    }
                }
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