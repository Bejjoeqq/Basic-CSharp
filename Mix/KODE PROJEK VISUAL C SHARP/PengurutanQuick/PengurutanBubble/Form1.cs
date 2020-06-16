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
        const int UKURAN_ARRAY = 10;

        //Variabel-variabel global
        int[] arrayKu = new int[UKURAN_ARRAY];

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolUrutQuick_Click(object sender, EventArgs e)
        {
            kotakList.Items.Add("=========ARRAY AWAL=========");
            MuatArray();
            TampilArray();
            kotakList.Items.Add("");

            kotakList.Items.Add("======HASIL PENGURUTAN======");
            PengurutanQuickRekursif(arrayKu, 0, UKURAN_ARRAY-1);
            kotakList.Items.Add("");

            TampilArray();
        }

        // Untuk menghasilkan indeks pivot
        int partisi(int[] arr, int awal, int akhir)
        {
            // Asumsi elemen akhir array sebagai elemen pivot
            int pivot = akhir;
            int i = awal, j = akhir, temp;
            while (i < j)
            {
                // menjelajah array dan mencari indeks dimana elemen lebih besar dari pivot
                while (i < akhir && arr[i] < arr[pivot])
                    i++;
                // menjelajah array dan mencari indeks dimana elemen lebih kecil dari pivot
                while (j > awal && arr[j] > arr[pivot])
                    j--;

                //menukar elemen-elemen pada indeks i dan j
                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            //terakhir menempatkan elemen pivot pada posisi tepat di dalam array
            temp = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = temp;
            // menghasilkan indeks pivot
            return j;
        }

        // Metode pengurutan quick
        void PengurutanQuickRekursif(int[] arr, int awal, int akhir)
        {
            if (awal < akhir)
            {
                // mencari indeks pivot
                int indeksPivot = partisi(arr, awal, akhir);
                // secara rekursif memanggil diri sendiri untuk elemen array sebelum indeks pivot
                PengurutanQuickRekursif(arr, awal, indeksPivot - 1);
                // secara rekursif memanggil diri sendiri untuk elemen array setelah indeks pivot
                PengurutanQuickRekursif(arr, indeksPivot + 1, akhir);
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