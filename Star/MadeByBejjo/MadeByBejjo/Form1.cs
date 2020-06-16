using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace MadeByBejjo
{
    public partial class Form1 : Form
    {
        int a,z;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (a == 1)
            {
            }
            else if (a == 2)
            {
            }
            else
            {
                System.Diagnostics.Process.Start("shutdown","/s /t 10");
                MessageBox.Show("Jangan Melarikan Diri", "Shutdown");
                Application.Exit();
            }
        }
        
        int coba = 0;
        private void btnProses_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username Tidak Boleh Kosong", "Perhatikan Kembali");
            }
            else if (txtPw.Text == "")
            {
                MessageBox.Show("Password Tidak Boleh Kosong", "Perhatikan Kembali");
            }
            else if (txtUser.Text.Equals("Bejjoeqq") && txtPw.Text.Equals("Aldhiyarozak"))
            {
                timer1.Stop();
                a = 1;
                MessageBox.Show("Welcome Bejjoeqq","Welcome");
                result rs = new result();
                rs.ShowDialog();
            }
            else
            {
                coba++;
                if (coba == 3)
                {
                    a = 2;
                    System.Diagnostics.Process.Start("shutdown", "/s /t 10");
                    MessageBox.Show("Percobaan Habis", "Shutdown");
                    Application.Exit();
                }
                else if (coba == 2)
                {
                    MessageBox.Show("Password Atau Username Salah","Coba Kembali");
                    MessageBox.Show("1 Kesempatan lagi, Periksa Kembali", "Kesempatan Kedua");
                }
                else if (coba == 1)
                {
                    MessageBox.Show("Password Atau Username Salah", "Coba Kembali");
                    MessageBox.Show("2 Kesempatan lagi, Periksa Kembali", "Kesempatan Pertama");
                }
            }
        }
        int min = 1;
        int sec = 29;
        int ms = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblRahasia.Hide();
            label5.Hide();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = min + " : " + sec + " : " + ms.ToString();
            ms--;
            if (min == 0 && sec == 0 && ms == 0)
            {
                ms = 0;
                timer1.Stop();
                label3.Text = min + " : " + sec + " : " + ms.ToString();
                a = 2;
                System.Diagnostics.Process.Start("shutdown", "/s /t 10");
                MessageBox.Show("Waktu Habis", "Shutdown");
                Application.Exit();
            }
            else if (sec == 0 && ms == 0)
            {
                min = 0;
                sec = 59;
                ms = 10;
            }
            else if (ms == 0)
            {
                ms = 10;
                sec--;
            }


        }

        private void appToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create By Bejjoeqq XI-RPL", "Just For Fun ^_^");
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit Our Website : www.itkonferensi.16mb.com", "About Creator");
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showToolStripMenuItem.Text == "Show")
            {
                lblRahasia.Show();
                label5.Show();
                showToolStripMenuItem.Text = "Hide";
            }
            else if (showToolStripMenuItem.Text == "Hide")
            {
                lblRahasia.Hide();
                label5.Hide();
                showToolStripMenuItem.Text = "Show";
            }
        }

        private void lblRahasia_Click(object sender, EventArgs e)
        {
            SecretForm sf = new SecretForm();
            sf.ShowDialog(this);
        }
    }
}
