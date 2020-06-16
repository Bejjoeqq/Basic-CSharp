using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelewatkanArrayKepadaMetode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DialogResult InputBox(string judul, string promptTeks, ref double nilai)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.Text = judul;
            label.Text = promptTeks;
            textBox.Text = nilai.ToString();
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);
            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            nilai = double.Parse(textBox.Text);
            return dialogResult;
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            //Menciptakan sebuah array untuk memuat jumlah-jumlah penjualan
            const int intSubskrip_Maks = 4;
            double[] decPenjualan = new double[intSubskrip_Maks];

            //Variabel lokal lainnya
            double decPenjualanTotal;       //untuk memuat penjualan total
            double decPenjualanRatarata;    //untuk memuat penjualan rerata
            double decPenjualanTertinggi;   //untuk memuat penjualan tertinggi
            double decPenjualanTerendah;    //untuk memuat penjualan terendah

            //Memabaca jumlah penjualan dari pengguna
            BacaDataPenjualan(decPenjualan);

            //Membaca penjualan total, penjualan rerata, penjualan tertinggi
            //dan penjualan terendah
            decPenjualanTotal = ArrayTotal(decPenjualan);
            decPenjualanRatarata = ArrayRerata(decPenjualan);
            decPenjualanTertinggi = Tertinggi(decPenjualan);
            decPenjualanTerendah = Terendah(decPenjualan);

            //Menampilkan hasil
            teksTotal.Text = decPenjualanTotal.ToString("N");
            teksRata.Text = decPenjualanRatarata.ToString("N");
            teksTertinggi.Text = decPenjualanTertinggi.ToString("N");
            teksTerendah.Text = decPenjualanTerendah.ToString("N");
        }

        //Metode BacaDataPenjualan menerima sebuah argumen array Decimal.
        private void BacaDataPenjualan(double[] decPenjualan)
        {
            int intHitung = 0; //kounter loop, ditetapkan 0

            //Mengisi array decPenjualan dengan nilai-nilai
            //yang dimasukkan oleh pengguna.
            while (intHitung < decPenjualan.Length)
            {
                try
                {
                    //Membaca penjualan
                    double nilaiMasukan = 0;
                    if (InputBox("Masukkan Nomor Karyawan", "Nilai penjualan hari ke:" + 
                        (intHitung + 1).ToString(), ref nilaiMasukan) == DialogResult.OK)
                    {
                        decPenjualan[intHitung] = nilaiMasukan;
                    }
                    intHitung += 1;
                }
                catch
                {
                    //Menampilkan pesan error
                    MessageBox.Show("Masukkan nilai numerik.");
                }
            }
        }

        //Metode ArrayTotal meneriman sebuah array Decimal sebagai
        //argumen dan menghasilkan total dari elemen-elemennya.
        private double ArrayTotal(double[] decNilai)
        {
            double decTotal = 0;    //akumulator
            int intHitung;          //kounter loop

            //Menghitung total dari tiap elemen array
            for (intHitung = 0; intHitung < decNilai.Length; intHitung++)
                decTotal += decNilai[intHitung];

            //Menghasilkan total.
            return decTotal;
        }

        //Metode ArrayRerata menerima sebuah array Decimal sebagai
        //argumen dan menghasilkan rerata dari elemen-elemennya.
        private double ArrayRerata(double[] decNilai)
        {
            return ArrayTotal(decNilai) / decNilai.Length;
        }

        //Metode Tertinggi menerima sebuah array Decimal array sebagai
        //argumen dan menghasilkan elemen tertinggi.
        private double Tertinggi(double[] decNilai)
        {
            int intHitung;          //kounter loop
            double decTertinggi;    //menampung nilai tertinggi

            //Membaca elemen pertama pada array.
            decTertinggi = decNilai[0];

            //Mencari nilai tertinggi
            for (intHitung = 1; intHitung < decNilai.Length; intHitung++)
            {
                if (decNilai[intHitung] > decTertinggi)
                    decTertinggi = decNilai[intHitung];
            }

            //Menghasilkan nilai tertinggi
            return decTertinggi;
        }

        //Metode Terendah menerima sebuah array Decimal array sebagai
        //argumen dan menghasilkan elemen terendah.
        private double Terendah(double[] decNilai)
        {
            int intHitung;          //kounter loop
            double decTerendah;     //memuat nilai terendah

            //membaca elemen pertama pada array
            decTerendah = decNilai[0];

            //Mencari nilai terendah
            for (intHitung = 1; intHitung < decNilai.Length; intHitung++)
            {
                if (decNilai[intHitung] < decTerendah)
                    decTerendah = decNilai[intHitung];
            }
            //Menghasilkan nilai terendah
            return decTerendah;
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}