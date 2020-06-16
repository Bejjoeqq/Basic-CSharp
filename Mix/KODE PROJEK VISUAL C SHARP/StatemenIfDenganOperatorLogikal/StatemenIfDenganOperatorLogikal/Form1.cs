using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatemenIfDenganOperatorLogikal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolEvaluasi_Click(object sender, EventArgs e)
        {
            Int16 jawaban;
            jawaban = Int16.Parse(teksJawaban.Text);
            if ((jawaban >= 30) && (jawaban <= 35))
                teksHasil.Text = "Bagus, Taksiran Anda hampir benar." +
                    " Ada 33 propinsi di Indonesia";
            else
                teksHasil.Text = "Tebakan Anda masih jauh dari jawaban ";
        }
    }
}
