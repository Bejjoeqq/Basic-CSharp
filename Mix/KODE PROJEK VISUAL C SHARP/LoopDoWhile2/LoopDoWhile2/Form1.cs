using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopDoWhile2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolDemo_Click(object sender, EventArgs e)
        {
            Int16 intKounter = 0;
            do
            {
                listKeluaran.Items.Add("Teknik Elektro");
                intKounter += 1;
            } while (intKounter < 10);
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            listKeluaran.Items.Clear();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
