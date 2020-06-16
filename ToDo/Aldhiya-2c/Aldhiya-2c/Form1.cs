using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya_2c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/mm/yyyy");
            label3.Text = DateTime.Now.ToString("hh:mm:ssss");
        }
    }
}
