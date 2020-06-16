using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AldhiyaProjectIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x,y=0;
        double harga;
        private void Form1_Load(object sender, EventArgs e)
        {
            x = 5;
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Uang.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from Money where ID='1';";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    double money = Convert.ToDouble(myreader["Total"]);
                    harga = money;
                }
            }
            catch (Exception)
            {
            }
            timer1.Start();
        }
        string[] arr = new String[10];
        private void kendaraanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (y < x)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
                y++;
            }
            else
            {
                MessageBox.Show("Kapasitas Penuh", "Silahkan Tambahkan Kapasitas");
            }
        }

        private void hasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int ms,sec,min,h;
        private void timer1_Tick(object sender, EventArgs e)
        { 
            ms++;
            if (min == 59 && sec == 59 && ms == 9)
            {
                h++;
                min = 0;
                sec = 0;
                ms = 0;
            }
            else if (sec == 59 && ms == 9)
            {
                min++;
                sec = 0;
                ms = 0;
            }
            else if (ms == 9)
            {
                sec++;
                ms = 0;
                string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Uang.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                string query = "select * from Money where ID='1';";
                SqlConnection con = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {
                        double money = Convert.ToDouble(myreader["Total"]);
                        harga = money;
                    }
                }
                catch (Exception)
                {
                }
            }
            label1.Text = "Rp." + harga.ToString("N");
        }

        private void kapasitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            x++;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            x--;
            if (x <= 1)
            {
                MessageBox.Show("Kapasitas Sudah Paling Sedikit");
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bisa Menampung Kendaraan Roda 4 Sebanyak "+x.ToString());
        }
    }
}
