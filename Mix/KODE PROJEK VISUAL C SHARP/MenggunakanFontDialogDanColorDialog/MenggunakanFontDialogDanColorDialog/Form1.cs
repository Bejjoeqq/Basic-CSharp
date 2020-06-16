using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenggunakanFontDialogDanColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolDemoColorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                label1.ForeColor = colorDialog1.Color;
        }

        private void tombolDemoFontDialog_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
                label1.ForeColor = fontDialog1.Color;
            }
        }
    }
}
