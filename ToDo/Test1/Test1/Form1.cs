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
    public partial class Form1 : Form
    {
        string c;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string a)
            : this()
        {
            txtPass.Text = a;
            c = Convert.ToString(txtPass.Text);
            txtPass.Text = "";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username Tidak Boleh Kosong");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Password Tidak Boleh Kosong");
            }

            if (txtUser.Text.Equals("Bejjo") && txtPass.Text.Equals(c))
            {
                MessageBox.Show("Login Sukses");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Username Atau Password Salah");
            }

        }

        private void btnPindah_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
