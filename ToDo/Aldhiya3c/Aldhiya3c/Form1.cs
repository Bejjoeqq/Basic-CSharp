using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya3c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboNama.Items.Add("Andi");
            cboNama.Items.Add("Budi");
            cboNama.Items.Add("Cici");
            cboNama.Items.Add("Dodi");
            cboNama.Items.Add("Edi");
            cboNama.Items.Add("Fitri");
            cboNama.Items.Add("Gandhi");
            cboNama.Items.Add("Hari");
            cboNama.Items.Add("Indri");
            cboNama.Items.Add("Jamali");
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            lstNama.Items.Add(cboNama.Text);
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            lstNama.Items.Remove(cboNama.Text);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            lstNama.Items.Clear();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
