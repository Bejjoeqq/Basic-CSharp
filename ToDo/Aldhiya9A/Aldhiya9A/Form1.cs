using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya9A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Nim", 80);
            listView1.Columns.Add("Nama", 80);
            listView1.Columns.Add("Prodi", 80);

            txtNim.Text = "165325";
            txtNama.Focus();
        }
        double a;
        private void btnData_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtNim.Text);
            string[] ar = new string[3];
            ar[0] = txtNim.Text;
            ar[1] = txtNama.Text;
            ar[2] = txtStudi.Text;

            ListViewItem item;

            item = listView1.Items.Add(ar[0]);
            item.SubItems.Add(ar[1]);
            item.SubItems.Add(ar[2]);

            a = a + 1;
            txtNim.Text = a.ToString();
            txtNama.Text = "";
            txtStudi.Text = "";
            txtNama.Focus();
        }
    }
}
