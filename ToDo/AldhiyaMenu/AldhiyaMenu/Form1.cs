using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin Mau Keluar ?", "Exit",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.ForeColor = Color.White;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.ForeColor = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.ForeColor = Color.Yellow;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.ForeColor = Color.Black;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.BackColor = Color.Black;
        }

        private void peachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.BackColor = Color.PeachPuff;
        }

        private void puffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.BackColor = Color.LightPink;
        }

        private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.BackColor = Color.LightBlue;
        }

        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.BackColor = Color.Gold;
        }

        private void upperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.Text = txtTampil.Text.ToUpper();
        }

        private void lowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.Text = txtTampil.Text.ToLower();
        }

        private void textColourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtTampil.Clear();
            txtTampil.ForeColor = Color.Black;
            txtTampil.BackColor = Color.White;
            MessageBox.Show("Text Colour Untuk Merubah Warna Text", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundColourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtTampil.Clear();
            txtTampil.ForeColor = Color.Black;
            txtTampil.BackColor = Color.White;
            MessageBox.Show("Text Colour Untuk Merubah Warna Background", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fontCaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtTampil.Clear();
            txtTampil.ForeColor = Color.Black;
            txtTampil.BackColor = Color.White;
            MessageBox.Show("Text Colour Untuk Merubah Bentuk Huruf", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void middleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.TextAlign = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.TextAlign = HorizontalAlignment.Right;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTampil.TextAlign = HorizontalAlignment.Left;
        }

        private void diskoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int sec = 1;
        int ms = 5;
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            ms--;
            if (sec == 0 && ms == 0)
            {
                sec = 1;
                ms = 5;
                x++;
            }
            else if (ms == 0)
            {
                ms = 5;
                sec--;
            }
            if (x == 1)
            {
                txtTampil.ForeColor = Color.Maroon;
            }
            else if (x == 2)
            {
                txtTampil.ForeColor = Color.Red;
            }
            else if (x == 3)
            {
                txtTampil.ForeColor = Color.LightCoral;
            }
            else if (x == 4)
            {
                txtTampil.ForeColor = Color.Coral;
            }
            else if (x == 5)
            {
                txtTampil.ForeColor = Color.Chocolate;
            }
            else if (x == 6)
            {
                txtTampil.ForeColor = Color.DarkGoldenrod;
            }
            else if (x == 7)
            {
                txtTampil.ForeColor = Color.OliveDrab;
            }
            else if (x == 8)
            {
                txtTampil.ForeColor = Color.ForestGreen;
            }
            else if (x == 9)
            {
                txtTampil.ForeColor = Color.MediumSeaGreen;
            }
            else if (x == 10)
            {
                txtTampil.ForeColor = Color.DeepSkyBlue;
            }
            else if (x == 11)
            {
                txtTampil.ForeColor = Color.RoyalBlue;
            }
            else if (x == 12)
            {
                txtTampil.ForeColor = Color.SlateBlue;
            }
            else if (x == 13)
            {
                txtTampil.ForeColor = Color.Crimson;
            }
            else if (x == 14)
            {
                txtTampil.ForeColor = Color.Black;
                x = 0;
            }
        }

        private void stopDiskoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
