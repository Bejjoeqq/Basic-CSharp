using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NusantaraProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        string posisi;
        public Admin(string a)
            : this()
        {
            posisi = a;
            label2.Text = a;
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
