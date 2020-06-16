using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelewatanDenganNilai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolGo_Click(object sender, EventArgs e)
        {
            int intAngka = 100;
            kotakList.Items.Add("Di dalam tombolGo_Click, nilai dari " +
                "intAngka adalah " + intAngka.ToString());
            kotakList.Items.Add("Sekarang UbahArg dipanggil:");
            UbahArg(ref intAngka);
            kotakList.Items.Add("Sekarang kembali ke tombolGo_Click, " +
                "nilai dari intAngka adalah " + intAngka.ToString());
        }

        private void UbahArg(ref int intArg)
        {
            //Menampilkan nilai dari intArg
            kotakList.Items.Add(" ");
            kotakList.Items.Add("Di dalam prosedur UbahArg, " + "intArg bernilai: " +
                intArg.ToString());
            kotakList.Items.Add("Saya akan mengubah nilai dari intArg.");

            //Menugaskan 0 kepada intArg
            intArg = 0;
            //Menampilkan nilai dari intArg
            kotakList.Items.Add("intArg sekarang bernilai: " + intArg.ToString());
            kotakList.Items.Add(" ");
        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            kotakList.Items.Clear();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}