using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace tesspkl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hasil1,hasil2;
        string tabel;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string contoh ,lgh;
            int a;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                contoh = dlg.SafeFileName.ToString();
                hasil2 = dlg.FileName.ToString();
                lgh = contoh.Length.ToString();
                a = Convert.ToInt32(lgh)-4;
                hasil1 = contoh.Remove(a);
                label1.Text = hasil1.ToString();
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabel = textBox1.Text;
            if (comboBox1.Text == "Mysql")
            {
                try
                {
                    string data = "SERVER=localhost;" + "DATABASE=" + hasil1 + ";" + "UID=root;" + "PASSWORD=;";
                    MySqlConnection koneksi = new MySqlConnection(data);
                    koneksi.Open();

                    MySqlCommand command = koneksi.CreateCommand();
                    command.CommandText = "SELECT * FROM "+tabel;
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    DataTable dt = new DataTable();


                    sda.SelectCommand = command;
                    sda.Fill(dt);
                    BindingSource bs = new BindingSource();

                    bs.DataSource = dt;
                    dataGridView1.RowTemplate.Height = 60;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.DataSource = bs;
                    MessageBox.Show("Koneksi Sukses !!");
                    panel1.Show();
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi Gagal : " + ex.Message);
                }
            }
            else if (comboBox1.Text == "SQL SERVER")
            {
                string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+hasil2+";Integrated Security=True;Connect Timeout=30;User Instance=True;";
                string query = "select * from "+tabel; 
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection condb = new SqlConnection(constring);
                SqlCommand cmddb = new SqlCommand(query, condb);
                try
                {
                    sda.SelectCommand = cmddb;
                    sda.Fill(dt);
                    BindingSource bs = new BindingSource();

                    bs.DataSource = dt;
                    dataGridView1.RowTemplate.Height = 60;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.DataSource = bs;

                    panel1.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ada Kesalahan", "Teliti Kembali");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Mysql";
            label1.Text = "";
            panel1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mysql")
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                label1.Text = "";
            }
            else if (comboBox1.Text == "SQL SERVER")
            {
                textBox2.Enabled = false;
                textBox2.Text = "";
                label1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
            hasil1 = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
