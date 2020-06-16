using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAwan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolDeskripsi_Click(object sender, EventArgs e)
        {
            if (radio1.Checked)
                teksKeluaran.Text = "Bersih (cerah)";
            else if (radio2.Checked)
                teksKeluaran.Text = "Sebagian Berawan";
            else if (radio3.Checked)
                teksKeluaran.Text = "Berawan";
            else
                teksKeluaran.Text = "Gelap";
        }
    }
}
