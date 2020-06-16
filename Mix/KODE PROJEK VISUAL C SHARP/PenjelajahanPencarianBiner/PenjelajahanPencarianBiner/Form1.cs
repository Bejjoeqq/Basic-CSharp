using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjelajahanPencarianBiner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolJelajah_Click(object sender, EventArgs e)
        {
            PohonPencarianBiner angka = new PohonPencarianBiner();
            string stringHasil1 = "";
            string stringHasil2 = "";
            string stringHasil3 = "";

            angka.Sisip(23);
            angka.Sisip(45);
            angka.Sisip(16);
            angka.Sisip(37);
            angka.Sisip(3);
            angka.Sisip(99);
            angka.Sisip(22);

            kotakListInorder.Items.Add("Penjelajahan Inorder: ");
            stringHasil1 = angka.PenjelajahanInOrder(angka.akar);
            kotakListInorder.Items.Add(stringHasil1);
            kotakListPreorder.Items.Add("Penjelajahan Preorder: ");
            stringHasil2 = angka.PenjelajahanPreOrder(angka.akar);
            kotakListPreorder.Items.Add(stringHasil2);
            kotakListPostorder.Items.Add("Penjelajahan Postorder: ");
            stringHasil3 = angka.PenjelajahanPostOrder(angka.akar);
            kotakListPostorder.Items.Add(stringHasil3);
        }
    }

    public class Simpul
    {
        public int iData;
        public Simpul Kiri;
        public Simpul Kanan;
    }

    public class PohonPencarianBiner
    {
        public Simpul akar;
        string stringKu1 = "";
        string stringKu2 = "";
        string stringKu3 = "";

        public PohonPencarianBiner()
        {
            akar = null;
        }

        public void Sisip(int i)
        {
            Simpul simpulBaru = new Simpul();
            simpulBaru.iData = i;
            if (akar.iData != null)
                akar = simpulBaru;
            else
            {
                Simpul skrg = akar;
                Simpul induk;
                while (true)
                {
                    induk = skrg;
                    if (i < skrg.iData)
                    {
                        skrg = skrg.Kiri;
                        if (skrg.Equals(null))
                        {
                            induk.Kiri = simpulBaru;
                            break;
                        }
                    }
                    else
                    {
                        skrg = skrg.Kanan;
                        if (skrg.Equals(null))
                        {
                            induk.Kanan = simpulBaru;
                            break;
                        }
                    }
                }
            }
        }

        public string PenjelajahanInOrder(Simpul akar)
        {
            if (!(akar.Equals(null)))
            {
                PenjelajahanInOrder(akar.Kiri);
                stringKu1 += akar.iData.ToString() + " ";
                PenjelajahanInOrder(akar.Kanan);
            }
            return stringKu1;
        }

        public string PenjelajahanPreOrder(Simpul akar)
        {
            if (!(akar.Equals(null)))
            {
                stringKu2 += akar.iData.ToString() + " ";
                PenjelajahanPreOrder(akar.Kiri);
                PenjelajahanPreOrder(akar.Kanan);
            }
            return stringKu2;
        }

        public string PenjelajahanPostOrder(Simpul akar) 
        {
            if (!(akar.Equals(null)))
            {
                PenjelajahanPostOrder(akar.Kiri);
                PenjelajahanPostOrder(akar.Kanan);
                stringKu3 += akar.iData.ToString() + " ";
            }
            return stringKu3;
        }
    }
}
