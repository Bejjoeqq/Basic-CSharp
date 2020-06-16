using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya_2b
{
    public partial class frmLatihan : Form
    {
        public frmLatihan()
        {
            InitializeComponent();
        }

        private void frmLatihan_Load(object sender, EventArgs e)
        {
            lblText1.Text = "SMK TELKOM MEDAN";
            lblText2.Text = "Nama  : Aldhiya Rozak";
            lblText3.Text = "NIS   : 165325";
            lblText4.Text = "Kelas : XI-RPL";
        }
    }
}
