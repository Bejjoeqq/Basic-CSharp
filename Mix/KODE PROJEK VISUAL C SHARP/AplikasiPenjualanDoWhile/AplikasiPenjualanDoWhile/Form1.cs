using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPenjualanDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool ApaNumerik(string masukan)
        {
            double uji;
            return double.TryParse(masukan, out uji);
        }

        public static DialogResult InputBox(string judul, string promptTeks, ref string nilai)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = judul;
            label.Text = promptTeks;
            textBox.Text = nilai;

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
            nilai = textBox.Text;
            return dialogResult;
        }

        private void tombolMasukkan_Click(object sender, EventArgs e)
        {
            const Int16 intJUM_HARI = 5; // Jumlah hari
            Int16 intKounter = 1;        //Kounter loop
            Double decPenjualan = 0; //untuk menampung penjualan harian
            Double decTotal = 0; //untuk memuat penjualan total
            //String strMasukan;    //untuk menampung string masukan

            //membaca penjualan tiap hari
            do {
                //membaca penjualan per hari dari pengguna
                string strMasukan = "";
     
                if (InputBox("Masukkan Penjualan Hari Ini", "Nilai Penjualan:", ref strMasukan) == DialogResult.OK)
                {
                    teksHasil.Name = strMasukan;
                }

                //Mengkonversi masukan menjadi Decimal.
                if (ApaNumerik(strMasukan)) {
                    decPenjualan = Double.Parse(strMasukan);
                    //Menambahkan penjualan harian pada penjualan total
                    decTotal += decPenjualan;
                    //Menambahkan 1 pada kounter loop
                    intKounter += 1;
                }
                else
                    //Menampilkan pesan error jika masukan tak-valid
                    MessageBox.Show("Masukkan angka numerik");
            }while (intKounter <= intJUM_HARI);

            //Menampilkan penjualan total
            teksHasil.Text = "Rp. " + decTotal.ToString("N");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
