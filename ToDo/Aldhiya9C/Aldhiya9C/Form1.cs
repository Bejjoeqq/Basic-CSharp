using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya9C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Nama, nama, Kbuku, Kbuku1, Kbuku2, Kobuku, Kobuku1, Kobuku2;
        private void Form1_Load(object sender, EventArgs e)
        {
            lstv1.GridLines = true;
            lstv1.View = View.Details;
            lstv1.Columns.Add("No. Peminjaman", 80);
            lstv1.Columns.Add("No. KTM",80);
            lstv1.Columns.Add("Nama",80);
            lstv1.Columns.Add("Kode Buku 1", 80);
            lstv1.Columns.Add("Judul Buku 1", 80);
            lstv1.Columns.Add("Kode Buku 2", 80);
            lstv1.Columns.Add("Judul Buku 2", 80);
            lstv1.Columns.Add("Kode Buku 3", 80);
            lstv1.Columns.Add("Judul Buku 3", 80);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string[] arr = new String[9];
            arr[0] = txtPemin.Text;
            arr[1] = cboNO.Text;
            arr[2] = txtNama.Text;
            arr[3] = cbo1.Text;
            arr[4] = txt4.Text;
            arr[5] = cbo2.Text;
            arr[6] = txt5.Text;
            arr[7] = cbo3.Text;
            arr[8] = txt6.Text;
            ListViewItem daftaritem;
            daftaritem = lstv1.Items.Add(arr[0]);
            daftaritem.SubItems.Add(arr[1]);
            daftaritem.SubItems.Add(arr[2]);
            daftaritem.SubItems.Add(arr[3]);
            daftaritem.SubItems.Add(arr[4]);
            daftaritem.SubItems.Add(arr[5]);
            daftaritem.SubItems.Add(arr[6]);
            daftaritem.SubItems.Add(arr[7]);
            daftaritem.SubItems.Add(arr[8]);

            txtPemin.Text = txtPemin.Text;
            cboNO.Text = "";
            txtNama.Text = "";
            cbo1.Text = "";
            txt4.Text = "";
            cbo2.Text = "";
            txt5.Text = "";
            cbo3.Text = "";
            txt6.Text = "";
        }

        private void cboNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nama = Convert.ToString(cboNO.Text);
            switch (Nama)
            {
                case "165324":
                    nama = "Aditya";
                    break;
                case "165325":
                    nama = "Aldhiya";
                    break;
                case "165326":
                    nama = "Aldiansyah";
                    break;
                case "165327":
                    nama = "Arief";
                    break;
                case "165328":
                    nama = "Aldo";
                    break;
                default:
                    nama = "Budi";
                    break;
            }
            txtNama.Text = nama.ToString();
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kbuku = Convert.ToString(cbo1.Text);
            switch (Kbuku)
            {
                case "1":
                    Kbuku1 = "Algoritma Pemrograman";
                    break;
                case "2":
                    Kbuku1 = "Bahasa Pemrograman C";
                    break;
                case "3":
                    Kbuku1 = "Bahasa Pemrograman C++";
                    break;
                case "4":
                    Kbuku1 = "Pemrograman C# Level 1";
                    break;
                case "5":
                    Kbuku1 = "Pemrograman C# Level 2";
                    break;
                default:
                    Kbuku1 = "buku";
                    break;
            }

                    txt4.Text = Kbuku1.ToString();
            
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Kbuku2 = Convert.ToString(cbo2.Text);
            switch (Kbuku2)
            {
                case "1":
                    Kobuku2 = "Algoritma Pemrograman";
                    break;
                case "2":
                    Kobuku2 = "Bahasa Pemrograman C";
                    break;
                case "3":
                    Kobuku2 = "Bahasa Pemrograman C++";
                    break;
                case "4":
                    Kobuku2 = "Pemrograman C# Level 1";
                    break;
                case "5":
                    Kobuku2 = "Pemrograman C# Level 2";
                    break;
                default:
                    Kobuku2 = "buku";
                    break;
            }

            txt5.Text = Convert.ToString(Kobuku2);
            
        }
        string Kbuku3, Kobuku3;
        private void cbo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kbuku3 = Convert.ToString(cbo3.Text);
            switch (Kbuku2)
            {
                case "1":
                    Kobuku3 = "Algoritma Pemrograman";
                    break;
                case "2":
                    Kobuku3 = "Bahasa Pemrograman C";
                    break;
                case "3":
                    Kobuku3 = "Bahasa Pemrograman C++";
                    break;
                case "4":
                    Kobuku3 = "Pemrograman C# Level 1";
                    break;
                case "5":
                    Kobuku3 = "Pemrograman C# Level 2";
                    break;
                default:
                    Kobuku3 = "buku";
                    break;
            }

            txt6.Text = Convert.ToString(Kobuku3);
            

        }
    }
}
