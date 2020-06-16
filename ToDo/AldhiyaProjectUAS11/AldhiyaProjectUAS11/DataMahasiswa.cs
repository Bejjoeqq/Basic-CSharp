using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaProjectUAS11
{
    public partial class DataMahasiswa : Form
    {
        public DataMahasiswa()
        {
            InitializeComponent();
        }

        private void DataMahasiswa_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Nim", 80);
            listView1.Columns.Add("Nama", 80);
            listView1.Columns.Add("Prodi", 80);
            listView1.Columns.Add("Stambuk", 80);

            cbo1.Text = "1";
        }
        double a = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];

            arr[0] = cbo1.Text;
            arr[1] = txt1.Text;
            arr[2] = txt2.Text;
            arr[3] = txt3.Text;

            ListViewItem daftar;

            daftar = listView1.Items.Add(arr[0]);
            daftar.SubItems.Add(arr[1]);
            daftar.SubItems.Add(arr[2]);
            daftar.SubItems.Add(arr[3]);

            a++;
            cbo1.Text = a.ToString();
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
