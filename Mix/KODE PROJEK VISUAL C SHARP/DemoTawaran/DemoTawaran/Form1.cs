﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTawaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolEvaluasi_Click(object sender, EventArgs e)
        {
            double vol, biaya, biayaVolTambah;
            double biayaDiskon, selisih;
            int pilihan;
            String tawaranTerbaik;

            vol = 10;
            biaya = 9000;
            biayaVolTambah = biaya / (1.5 * vol);
            biayaDiskon = (0.65 * biaya) / vol;

            teksPersen.Text = "Rp. " + biayaVolTambah.ToString("N");
            teksDiskon.Text = "Rp. " + biayaDiskon.ToString("N");
            selisih = biayaVolTambah - biayaDiskon;

            if (selisih > 0)
                pilihan = 0;
            else if (selisih < 0)
                pilihan = 1;
            else
                pilihan = 2;
            switch (pilihan)
            {
                case 0:
                    tawaranTerbaik = "35 % diskon";
                    break;
                case 1:
                    tawaranTerbaik = "50 % volume lebih";
                    break;
                default:
                    tawaranTerbaik = "sama saja";
                    break;
            }
            teksTawaranTerbaik.Text = tawaranTerbaik;
        }
    }
}
