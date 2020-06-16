using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form2 : Form
    {
        string b;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string b;
            b = txtDaftar.Text;
            Form1 f1 = new Form1(b);
            f1.Show();
            this.Hide();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
