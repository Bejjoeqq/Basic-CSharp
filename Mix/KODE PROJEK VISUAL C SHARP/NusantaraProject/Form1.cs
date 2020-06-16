using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.IO;
using System.Reflection;

namespace NusantaraProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        string nama,posisi;
        public void FillDGVA()
        {
            string data = "SERVER=localhost;" + "DATABASE=nusantara;" + "UID=root;" + "PASSWORD=;";
            conn = new MySqlConnection(data);
            string query = "Select * From msemployee where Email='" + textBox1.Text + "'&& Password='" + textBox2.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader myreader;
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                if(dt.Rows[0][0].ToString() != "1")
                {
                    MessageBox.Show("a");
                }
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string nma = myreader["Name"].ToString();
                    string eml = myreader["Email"].ToString();
                    string pw = myreader["Password"].ToString();
                    string hp = myreader["Handphone"].ToString();
                    string pst = myreader["Position"].ToString();
                    posisi = pst;
                    nama = nma;
                }
            }
            catch (Exception)
            {
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FillDGVA();
            if (posisi == "Admin")
            {
                Admin ad = new Admin(nama);
                ad.Show();
                this.Hide();
            }
            else if (posisi == "Chef")
            {
                Admin ad = new Admin(nama);
                ad.Show();
                this.Hide();
            }
            else if (posisi == "Cashier")
            {
                Admin ad = new Admin(nama);
                ad.Show();
                this.Hide();
            }
        }
    }
}
