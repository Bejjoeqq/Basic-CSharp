using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaftarBulan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String hariDlmBulan = "", stringItem;
            int pilihan;
            stringItem = kotakList.Text;

            if ((stringItem == "September") || (stringItem == "April") ||
                (stringItem == "Juni") || (stringItem == "Nopember"))
                pilihan = 0;
            else if (stringItem == "Pebruari")
                pilihan = 1;
            else
                pilihan = 2;

            switch(pilihan) {
                case 0:
                    hariDlmBulan = "30";
                    break;
                case 1:
                    hariDlmBulan = "28 atau 29";
                    break;
                case 2:
                    hariDlmBulan = "31";
                    break;
            }
            teksHari.Text = hariDlmBulan;
        }
    }
}
