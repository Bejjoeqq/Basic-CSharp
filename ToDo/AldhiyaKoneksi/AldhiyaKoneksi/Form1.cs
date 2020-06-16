using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaKoneksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'siswasDataSet1.siswatbl' table. You can move, or remove it, as needed.
            this.siswatblTableAdapter.Fill(this.siswasDataSet1.siswatbl);
            // TODO: This line of code loads data into the 'siswasDataSet.siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.siswasDataSet.siswa);

        }
    }
}
