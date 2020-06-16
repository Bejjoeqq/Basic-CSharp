using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StatemenIf1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            int nilai = 0;
            nilai = int.Parse(teksNilai.Text);
            if (nilai < 50)
                kotakList.Text = "Gagal";
            else if (nilai < 60)
                kotakList.Text = "C";
            else if (nilai < 80)
                kotakList.Text = "B";
            else if (nilai < 101)
                kotakList.Text = "A";
            kotakList.Items.Add(nilai + " ==> " + kotakList.Text);
        }
    }
}
