using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaTugas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            lstBox.Items.Add(lblNama.Text);
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            lstBox.Items.Add(txtBox.Text);
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            lstBox.Items.Add(cboBox.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }
    }
}
