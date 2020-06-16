using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaProjectUAS11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataMahasiswa dm = new DataMahasiswa();
            dm.MdiParent = this;
            dm.Show();
        }

        private void dataDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataDosen dd = new DataDosen();
            dd.MdiParent = this;
            dd.Show();
        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPegawai dp = new DataPegawai();
            dp.MdiParent = this;
            dp.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileCascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
