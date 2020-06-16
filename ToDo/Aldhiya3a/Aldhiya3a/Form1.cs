using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya3a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnProses_Click_1(object sender, EventArgs e)
        {  
            lblTam.Text = TxtNama.Text;     
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            TxtNama.Text = "";
            lblTam.Text = "";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
