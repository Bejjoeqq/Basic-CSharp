using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RencanaLayananTelkomSelular
{
    public partial class Form1 : Form
    {
        //Variabel-variabel global
        int sngBiayaBulanan = 0;
        int sngJumMenit;
        int sngJumData;
        double sngTambahMenit;
        double sngTambahData;
        double SngVoice;
        double sngBiayaAkhir;
        string strRencana;

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            pilihRencana();
            hitung();
        }

        private void pilihRencana()
        {
            strRencana = CBstrRencana.SelectedItem.ToString();
            if (strRencana == "A")
            {
                sngBiayaBulanan = 290000;
                sngJumMenit = 150;
                sngJumData = 500;
                sngTambahMenit = 0.59;
                sngTambahData = 0.2;
                SngVoice = 0.2;
            }
            else if (strRencana == "B")
            {
                sngBiayaBulanan = 350000;
                sngJumMenit = 250;
                sngJumData = 600;
                sngTambahMenit = 0.59;
                sngTambahData = 0.2;
                SngVoice = 0.2;
            }
            else if (strRencana == "C")
            {
                sngBiayaBulanan = 450000;
                sngJumMenit = 350;
                sngJumData = 700;
                sngTambahMenit = 0.59;
                sngTambahData = 0.2;
                SngVoice = 0.2;
            }
            else if (strRencana == "D")
            {
                sngBiayaBulanan = 550000;
                sngJumMenit = 450;
                sngJumData = 800;
                sngTambahMenit = 0.59;
                sngTambahData = 0.2;
                SngVoice = 0.2;
            }
            else if (strRencana == "E")
            {
                sngBiayaBulanan = 650000;
                sngJumMenit = 550;
                sngJumData = 900;
                sngTambahMenit = 0.59;
                sngTambahData = 0.2;
                SngVoice = 0.2;
            }
            else if (strRencana == "F")
            {
                sngBiayaBulanan = 750000;
                sngJumMenit = 650;
                sngJumData = 1000;
                sngTambahMenit = 0.59;
                sngTambahData = 0.2;
                SngVoice = 0.2;
            }

            //Menempatkan teks pada batang judul
            Form1.ActiveForm.Text = "Anda memilih " + "Rencana " + strRencana;
        }

        private void hitung()
        {
            //menciptakan variabel-variabel untuk menampilkan data yang dimasukkan
            int sngMenitDigunakan = 0;
            int sngDataDigunakan = 0;
            int sngVoiceDigunakan = 0;

            //menciptakan variabel-variabel untuk menampung kelebihan penggunaan
            double sngEkstraMenit = 0;
            double sngEkstraData = 0;
            double sngBiayaVoice = 0;

            //Membaca data dari kotak teks
            sngMenitDigunakan = int.Parse(teksJumMenit.Text);
            sngDataDigunakan = int.Parse(teksData.Text);
            sngVoiceDigunakan = int.Parse(teksVoiceMail.Text);

            //biaya ekstra untuk kelebihan jumlah menit
            sngMenitDigunakan = sngMenitDigunakan - sngJumMenit;

            if (sngMenitDigunakan > 0)
                sngEkstraMenit = (sngMenitDigunakan * sngTambahMenit);
            else //tidak ada biaya ekstra jika kurang dari rencana
                sngEkstraMenit = 0;

            //biaya ekstra untuk kelebihan jumlah data
            sngDataDigunakan = sngDataDigunakan - sngJumMenit;

            if (sngDataDigunakan > 0)
                sngEkstraData = (sngDataDigunakan * sngTambahMenit);
            else //tidak ada biaya ekstra jika kurang dari rencana
                sngEkstraData = 0;

            //biaya VoiceMail
            sngBiayaVoice = SngVoice * sngVoiceDigunakan;

            //Biaya Akhir
            sngBiayaAkhir = (sngBiayaBulanan + sngEkstraMenit + sngEkstraData + sngBiayaVoice);
            kotakList.Items.Add("Rp. " + sngBiayaBulanan + "; Rencana " +
                strRencana + " Anda perlu membayar Rp. " + sngBiayaAkhir);
            labelHarga.Text = sngBiayaAkhir.ToString();

            //Menampilkan 3 label lagi
            labelData.Text = sngEkstraMenit.ToString();
            labelJumMenit.Text = "Rp. " + sngEkstraData.ToString();
            labelVoiceMail.Text = "Rp. " + sngBiayaVoice.ToString();
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
