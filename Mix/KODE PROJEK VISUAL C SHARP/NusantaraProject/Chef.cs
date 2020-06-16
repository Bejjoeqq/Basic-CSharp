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
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
        }
        string posisi;
        public Chef(string a)
            : this()
        {
            posisi = a;
            label2.Text = a;
        }
        private void Chef_Load(object sender, EventArgs e)
        {

        }
    }
}
