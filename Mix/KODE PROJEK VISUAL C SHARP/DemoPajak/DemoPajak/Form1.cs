using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPajak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            //Menghitung pajak sosial dan pajak kesehatan
            //untuk tiap wajib pajak pada tahun 2014
            //Tidak ada pajak sosial untuk penghasilan di atas ini
            const double GAJI_POKOK = 100000000;
            const double PERSEN_PAJAK_SOSIAL = 0.062;
            const double PERSEN_PAJAK_KESEHATAN = 0.0145;
            double penghasilanThnLalu = 0, penghasilanSkrg = 0;
            double pajakSosial = 0, pajakKesehatan = 0, pajakTotal = 0;

            penghasilanThnLalu = Double.Parse(teksSblmSkrg.Text);
            penghasilanSkrg = Double.Parse(teksTglSkrg.Text);

            if ((penghasilanThnLalu + penghasilanSkrg) <= GAJI_POKOK)
                pajakSosial = PERSEN_PAJAK_SOSIAL * penghasilanSkrg;
            else if (penghasilanThnLalu < GAJI_POKOK)
                pajakSosial = PERSEN_PAJAK_SOSIAL * GAJI_POKOK - penghasilanThnLalu;

            pajakKesehatan = PERSEN_PAJAK_KESEHATAN * penghasilanSkrg;
            pajakTotal = pajakSosial + pajakKesehatan;
            teksPajak.Text = "Rp. " + pajakTotal.ToString();
        }
    }
}
