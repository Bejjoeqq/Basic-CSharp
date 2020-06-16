using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisNamaPresiden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            teksJawaban.Text = "Tepat!.";
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            teksJawaban.Text = "Maaf, nama penuhnya adalah " +
                "Megawati Sukarnoputri.";
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            teksJawaban.Text = "Apakah Anda orang Indonesia?";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            teksJawaban.Text = "Terimakasih.";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

    }
}
