using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorMenuKafe
{
    public partial class Form1 : Form
    {
        //Deklarasi-deklarasi level-kelas
        const double decBESAR_PAJAK = 0.06D;  //Besar pajak
        const double decBAGEL_WHITE = 12500D; //Biaya dari white bagel
        const double decBAGEL_WHEAT = 15000D; //Biaya dari whole wheat bagel
        const double decCREAM_CHEESE = 5000D; //Biaya dari cream cheese topping
        const double decBUTTER = 2500D;       //Biaya dari butter topping
        const double decBLUEBERRY = 7500D;    //Biaya dari blueberry topping
        const double decRASPBERRY = 7500D;    //Biaya dari raspberry topping
        const double decPEACH = 7500D;        //Biaya dari peach topping
        const double decREG_COFFEE = 12500D;  //Biaya dari regular coffee
        const double decCAPPUCCINO = 20000D;  //Biaya dari cappuccino
        const double decCAFE_AU_LAIT = 17500D; //Biaya dari Cafe au lait

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            //Prosedur ini menghitung total pesanan
            double decSubtotal; //Memuat subtotal pesanan
            double decTax;      //Memuat pajak penjualan
            double decTotal;    //Memuat total pesanan
            decSubtotal = HitungBiayaBagel() + HitungBiayaTopping() + HitungBiayaKopi();
            decTax = HitungPajak(decSubtotal);
            decTotal = decSubtotal + decTax;
            teksSubtotal.Text = "Rp. " + decSubtotal.ToString("N");
            teksPajak.Text = "Rp. " + decTax.ToString("N");
            teksTotal.Text = "Rp. " + decTotal.ToString("N");
        }

        private void tombolReset_Click(object sender, EventArgs e)
        {
            //Prosedur ini merset kontrol-kontrol menjadi nilai-nilai default
            ResetBagel();
            ResetTopping();
            ResetKopi();
            ResetHarga();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private double HitungBiayaBagel()
        {
            //Fungsi ini menghasilkan biaya dari bagel yang dipilih
            double decBagel;
            if (RBWhite.Checked == true)
                decBagel = decBAGEL_WHITE;
            else
                decBagel = decBAGEL_WHEAT;

            return decBagel;
        }

        private double HitungBiayaTopping()
        {
            //Fungsi ini menghasilkan biaya dari topping
            double decBiayaTopping = 0D;
            if (CBCream.Checked == true)
                decBiayaTopping += decCREAM_CHEESE;

            if (CBButter.Checked == true)
                decBiayaTopping += decBUTTER;

            if (CBBlueberry.Checked == true)
                decBiayaTopping += decBLUEBERRY;

            if (CBRaspberry.Checked == true)
                decBiayaTopping += decRASPBERRY;

            if (CBPeach.Checked == true)
                decBiayaTopping += decPEACH;

            return decBiayaTopping;
        }

        private double HitungBiayaKopi()
        {
            //Fungsi ini menghasilkan biaya dari kopi yang dipilih
            double decKopi = 0.0;
            if (RBTidak.Checked == true) 
                decKopi = 0D;
            else if (RBRegular.Checked == true) 
                decKopi = decREG_COFFEE;
            else if (RBCappuccino.Checked == true)
                decKopi = decCAPPUCCINO;
            else if (RBCafe.Checked == true) 
                decKopi = decCAFE_AU_LAIT;

            return decKopi;
        }

        private double HitungPajak(double decJumlahPenjualan)
        {
            //Fungsi ini menerima jumlah penjualan dan
            //menghasilkan total pajak
            return decJumlahPenjualan * decBESAR_PAJAK;
        }

        private void ResetBagel()
        {
            //Prosedur ini mereset pemilihan bagel
            RBWhite.Checked = true;
        }

        private void ResetTopping()
        {
            //Prosedur ini mereset pemilihan topping
            CBCream.Checked = false;
            CBButter.Checked = false;
            CBBlueberry.Checked = false;
            CBRaspberry.Checked = false;
            CBPeach.Checked = false;
        }

        private void ResetKopi()
        {
            //Prosedur ini mereset pemilihan kopi
            RBRegular.Checked = true;
        }

        private void ResetHarga()
        {
            //Prosedur ini mereset harga
            teksSubtotal.Text = String.Empty;
            teksPajak.Text = String.Empty;
            teksTotal.Text = String.Empty;
        }
    }
}