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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }
        string posisi;
        public Cashier(string a)
            : this()
        {
            posisi = a;
            label2.Text = a;
        }
        private void Cashier_Load(object sender, EventArgs e)
        {

        }
    }
}
