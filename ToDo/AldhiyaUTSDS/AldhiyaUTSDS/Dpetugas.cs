using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaUTSDS
{
    public partial class Dpetugas : Form
    {
        public Dpetugas()
        {
            InitializeComponent();
        }

        private void Dpetugas_Load(object sender, EventArgs e)
        {
            lstv1.GridLines = true;
            lstv1.View = View.Details;
            lstv1.Columns.Add("Kode Buku", 80);
            lstv1.Columns.Add("Judul", 80);
            lstv1.Columns.Add("Pengarang", 80);
            lstv1.Columns.Add("Penerbit", 80);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string[] arr = new String[4];
            arr[0] = textBox1.Text;
            arr[1] = textBox2.Text;
            arr[2] = textBox3.Text;
            arr[3] = textBox4.Text;
            ListViewItem daftaritem;
            daftaritem = lstv1.Items.Add(arr[0]);
            daftaritem.SubItems.Add(arr[1]);
            daftaritem.SubItems.Add(arr[2]);
            daftaritem.SubItems.Add(arr[3]);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstv1.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin Mau Keluar ?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
