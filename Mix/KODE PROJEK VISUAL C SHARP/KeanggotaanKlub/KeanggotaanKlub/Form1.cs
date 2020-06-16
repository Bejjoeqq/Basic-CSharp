using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeanggotaanKlub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            Double biaya = 0;
            if ((radDewasa.Checked) || (radSenior.Checked))
            {
                int jumEkstra = 0;
                if (checkTennis.Checked)
                    jumEkstra += 1;
                if (checkLocker.Checked)
                    jumEkstra += 1;
                if (checkLaundry.Checked)
                    jumEkstra += 1;
                if (radDewasa.Checked)
                    biaya = 100000 + (jumEkstra * 25000);
                else
                    biaya = 75000 + (jumEkstra * 25000);
            }
            teksBiaya.Text = "Rp. " + biaya.ToString("N");
        }
    }
}
