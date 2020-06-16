using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaTugasPraktekMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void luasPersegiPanjangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LPersegiPanjang a = new LPersegiPanjang();
            a.MdiParent = this;
            a.Show();
        }

        private void luasBujurSangkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LBujurSangkar b = new LBujurSangkar();
            b.MdiParent = this;
            b.Show();
        }

        private void luasSegitigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LSegitiga c = new LSegitiga();
            c.MdiParent = this;
            c.Show();
        }

        private void luasJajaranGenjangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LJajaranGenjang d = new LJajaranGenjang();
            d.MdiParent = this;
            d.Show();
        }

        private void luasLingkaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LLingkaran e1 = new LLingkaran();
            e1.MdiParent = this;
            e1.Show();
        }

        private void luasLayangLayangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LLayang_Layang f = new LLayang_Layang();
            f.MdiParent = this;
            f.Show();
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void kelilingPersegiPanjangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KPersegiPanjang a1 = new KPersegiPanjang();
            a1.MdiParent = this;
            a1.Show();
        }

        private void kelilingBujurSangkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KBujurSangkar b2 = new KBujurSangkar();
            b2.MdiParent = this;
            b2.Show();
        }

        private void kelilingSegitigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KSegitiga c1 = new KSegitiga();
            c1.MdiParent = this;
            c1.Show();
        }

        private void kelilingJajaranGenjangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KJajaranGenjang d1 = new KJajaranGenjang();
            d1.MdiParent = this;
            d1.Show();
        }

        private void kelilingLingkaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KLingkaran e11 = new KLingkaran();
            e11.MdiParent = this;
            e11.Show();
        }

        private void kelilingLayangLayangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KLayang_Layang f1 = new KLayang_Layang();
            f1.MdiParent = this;
            f1.Show();
        }

        private void volumeKubusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VKubus a0 = new VKubus();
            a0.MdiParent = this;
            a0.Show();
        }

        private void volumeBalokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBalok b0 = new VBalok();
            b0.MdiParent = this;
            b0.Show();
        }

        private void volumeTabungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VTabung c0 = new VTabung();
            c0.MdiParent = this;
            c0.Show();
        }

        private void volumeKerucutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VKerucut d0 = new VKerucut();
            d0.MdiParent = this;
            d0.Show();
        }

        private void volumeBolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBola e0 = new VBola();
            e0.MdiParent = this;
            e0.Show();
        }
    }
}
