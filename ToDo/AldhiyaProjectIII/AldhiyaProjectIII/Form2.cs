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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string kata,kataa,huruf;
        private void Form2_Load(object sender, EventArgs e)
        {
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
                    total = money;
                }
            }
            catch (Exception)
            {
            }
            timer1.Start();
            Random rnd = new Random();
            int [] af = new int[5];
            af[0] = rnd.Next(1, 9);
            af[1] = rnd.Next(1, 9);
            af[2] = rnd.Next(1, 9);
            af[3] = rnd.Next(1, 5);
            switch (af[3])
            {
                case 1: kata = "K";break;
                case 2: kata = "M";break;
                case 3: kata = ""; break;
                case 4: kata = "L";break;
                case 5: kata = "B";break;
            }
            af[4] = rnd.Next(1, 5);
            switch (af[4])
            {
                case 1: kataa = "A"; break;
                case 2: kataa = "B"; break;
                case 3: kataa = "C";break;
                case 4: kataa = "D"; break;
                case 5: kataa = "E"; break;
            }
            label3.Text = "B" + kata + af[0] + af[1] + af[2] + kataa;
            huruf = Convert.ToString(label3.Text);
        }
        int ms, sec, min, h;
        double harga,total;
        int[] waktu = new int[4];
        private void timer1_Tick(object sender, EventArgs e)
        {
            ms++;
            label1.Text = h + " : " + min + " : " + sec + " : " + ms;
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
                harga = harga + 5;
                total = total + 5; 
                string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Uang.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                string query = "update Money set Total='" + this.total + "' where ID='1' ";
                SqlConnection condb = new SqlConnection(constring);
                SqlCommand cmddb = new SqlCommand(query, condb);
                SqlDataReader myreader;
                try
                {
                    condb.Open();
                    myreader = cmddb.ExecuteReader();
                    while (myreader.Read())
                    {
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
                }  
            }
            label5.Text = "Rp." + harga.ToString("N");
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            total = total + harga;
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Uang.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update Money set Total='" + this.total + "' where ID='1' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ada Kesalahan!", "Laporkan Kepada Admin");
            }  
            this.Close();
        }
    }
}
