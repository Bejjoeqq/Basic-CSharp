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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double harga,total;
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Rp."+harga.ToString("N");
        }
    }
}
