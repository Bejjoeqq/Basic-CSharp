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
        int[] tempArray = new int[UKURAN_ARRAY];

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolUrutMerge_Click(object sender, EventArgs e)
        {
            kotakList.Items.Add("=========ARRAY AWAL=========");
            MuatArray();
            TampilArray();
            kotakList.Items.Add("");

            kotakList.Items.Add("======PROSES PENGURUTAN======");
            pengurutanMerge();
            kotakList.Items.Add("");

            kotakList.Items.Add("======HASIL PENGURUTAN======");
            TampilArray();
        }

        public void pengurutanMerge()
        {
            recMergeSort(tempArray, 0, arrayKu.Length - 1);
        }

        public void recMergeSort(int[] tempArray, int lbound, int ubound)
        {
            if (lbound == ubound)
                return;
            else
            {
                int mid = (lbound + ubound) / 2;
                recMergeSort(tempArray, lbound, mid);
                recMergeSort(tempArray, mid + 1, ubound);
                merge(tempArray, lbound, mid + 1, ubound);

                //menampilkan tiap baris array pada kotak list
                strArray = "";
                for (int i = 0; i < arrayKu.Length; i++)
                {
                    strArray += arrayKu[i].ToString() + " ";
                    kounter += 1;
                }
                kotakList.Items.Add("Inner " + dalam + ", Outer " + luar + ", " + strArray);
            }
        }

        public void merge(int[] tempArray, int lowp, int highp, int ubound)
        {
            int j = 0;
            int lbound = lowp;
            int mid = highp - 1;
            int n = ubound - lbound + 1;

            while ((lowp <= mid) && (highp <= ubound))
            {
                if (arrayKu[lowp] < arrayKu[highp]) 
                {
                    tempArray[j] = arrayKu[lowp];
                    j += 1;
                    lowp += 1;
                }
                else
                {
                    tempArray[j] = arrayKu[highp];
                    j += 1;
                    highp += 1;
                }
            }

            while (lowp <= mid)
            {
                tempArray[j] = arrayKu[lowp];
                j += 1;
                lowp += 1;
            }

            while (highp <= ubound)
            {
                tempArray[j] = arrayKu[highp];
                j += 1;
                highp += 1;
            }

            for (j = 0; j < n; j++)
                arrayKu[lbound + j] = tempArray[j];
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