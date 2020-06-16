using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya9B
{
    public partial class Form1 : Form
    {
        int indeks = 0;
        int jumlah = 4;
        string[] kode = new string[4];
        string[] nama = new string[4];
        string[] kemasan = new string[4];
        int[] hbeli = new int[4];
        int[] hjual = new int[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSimpan.Text = indeks.ToString();
            btnTampil.Hide();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (indeks >= jumlah - 1)
            {
                MessageBox.Show("List Sudah Penuh");
            }
            else
            {
                kode[indeks] = txtKode.Text;
                nama[indeks] = txtNama.Text;
                kemasan[indeks] = txtKemasan.Text;
                hbeli[indeks] = Convert.ToInt32(txtHbeli.Text);
                hjual[indeks] = Convert.ToInt32(txtHjual.Text);
                indeks = indeks + 1;
                lblSimpan.Text = indeks.ToString();

                txtKode.Text = "";
                txtNama.Text = "";
                txtKemasan.Text = "";
                txtHbeli.Text = "";
                txtHjual.Text = "";
                txtHjual.Focus();
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (indeks > 0)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        listView1.Items.Add(kode[0]);
                        listView1.Items.Add(kode[1]);
                        listView1.Items.Add(kode[2]);
                        break;
                    case 1:
                        listView1.Items.Add(nama[0]);
                        listView1.Items.Add(nama[1]);
                        listView1.Items.Add(nama[2]);
                        break;
                    case 2:
                        listView1.Items.Add(kemasan[0]);
                        listView1.Items.Add(kemasan[1]);
                        listView1.Items.Add(kemasan[2]);
                        break;
                    case 3:
                        listView1.Items.Add(hbeli[0].ToString());
                        listView1.Items.Add(hbeli[1].ToString());
                        listView1.Items.Add(hbeli[2].ToString());
                        break;
                    case 4:
                        listView1.Items.Add(hjual[0].ToString());
                        listView1.Items.Add(hjual[1].ToString());
                        listView1.Items.Add(hjual[2].ToString());
                        break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            indeks = 0;
            lblSimpan.Text = indeks.ToString();
            listView1.Items.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin Mau Keluar ?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void txtHbeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtHjual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
