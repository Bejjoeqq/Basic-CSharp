using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace inputt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a;
        private void btnP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string pic = dlg.FileName.ToString();
                a = pic;
                pictureBox1.ImageLocation = pic;
            }
            /*
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from fLogin where Username='" + txt1.Text + "';";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader = null;
            con.Open();
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                string pw = myreader["Password"].ToString();
                txt2.Text = pw;
            }
            */
            /*
            a = "100";
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Tes.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "update test set Nama='" + this.txt1.Text + "',Kelas='" + this.a + "' where Nama='" + this.txt1.Text + "' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                MessageBox.Show("Daftar Berhasil", "Selamat");
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Username Sudah Ada", "Coba Ulangi");
            }*/       
        }
        string b;
        double c;
        private void button1_Click(object sender, EventArgs e)
        {
            b = "coba";
            c = 0;

            byte[] im = null;
            FileStream st = new FileStream(this.a, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(st);
            im = br.ReadBytes((int)st.Length);

            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "insert into fLogin (Username, Password, Uang, Status, Poin, Gambar) values('" + this.b + "','" + this.b + "','" + this.c + "','" + this.b + "','" + this.c + "',@IMG) ;";
            SqlConnection cn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader rd;
            try
            {
                cn.Open();
                cmd.Parameters.Add(new SqlParameter("@IMG", im));
                rd = cmd.ExecuteReader();
                MessageBox.Show("assd");
                while (rd.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Salah");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "select * from fLogin where Username='" + txt1.Text + "';";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string nma = myreader["Username"].ToString();
                    string pw = myreader["Password"].ToString();
                    double money = Convert.ToDouble(myreader["Uang"]);
                    string stas = myreader["Status"].ToString();
                    double myp = Convert.ToDouble(myreader["Poin"]);
                    byte[] img = (byte[])(myreader["Gambar"]);
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Salah");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ACER VX 15 PREDATOR\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            string query = "delete from fLogin where Username='" + this.txt1.Text + "' ";
            SqlConnection condb = new SqlConnection(constring);
            SqlCommand cmddb = new SqlCommand(query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddb.ExecuteReader();
                MessageBox.Show("Berhasil", "Selamat");
                while (myreader.Read())
                {
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Username Sudah Ada", "Coba Ulangi");
            }
        }
    }
}
