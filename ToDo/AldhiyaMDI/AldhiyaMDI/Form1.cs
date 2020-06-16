using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI1 a = new MDI1();
            a.MdiParent = this;
            a.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MDI2 b = new MDI2();
            b.MdiParent = this;
            b.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MDI3 c = new MDI3();
            c.MdiParent = this;
            c.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MDI4 d = new MDI4();
            d.MdiParent = this;
            d.Show();
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileCascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeIcosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}

