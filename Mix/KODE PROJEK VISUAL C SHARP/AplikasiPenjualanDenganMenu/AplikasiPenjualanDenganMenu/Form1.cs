using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPenjualanDenganMenu
{
    public partial class Form1 : Form
    {
        //Aplikasi ini menampilkan laporan penjualan untuk perusahaan
        //Deklarai level-kelas
        const int intSUBSKRIP_MAKS = 4; //subksrip maksimum
        string[] strNamaProduk = new string[intSUBSKRIP_MAKS];  //nama produk
        string[] strDeskripsi = new string[intSUBSKRIP_MAKS];   //deskripsi
        int[] intNomorProduk = new int[intSUBSKRIP_MAKS];       //nomor produk
        double[] decHarga = new double[intSUBSKRIP_MAKS];       //harga per unit
        int[] intUnitTerjual = new int[intSUBSKRIP_MAKS];       //unit terjual

        public Form1()
        {
            InitializeComponent();
        }

        public static DialogResult InputBox(string judul, string promptTeks, ref int nilai)
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
            nilai = int.Parse(textBox.Text);
            return dialogResult;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Menginisialisasi array dengan data produk
            InisialisasiArray();
        }

        private void InisialisasiArray()
        {
            //Inisialisasi array
            //Produk pertama
            strNamaProduk[0] = "Pemrograman Java";
            strDeskripsi[0] = "Buku";
            intNomorProduk[0] = 914;
            decHarga[0] = 99900D;

            //Produk kedua
            strNamaProduk[1] = "Pemrograman VB.NET";
            strDeskripsi[1] = "CD";
            intNomorProduk[1] = 915;
            decHarga[1] = 75500D;

            //Produk ketiga
            strNamaProduk[2] = "Pemrograman MATLAB";
            strDeskripsi[2] = "Video";
            intNomorProduk[2] = 916;
            decHarga[2] = 185500D;

            //Produk keempat
            strNamaProduk[3] = "Pemrograman C#.NET";
            strDeskripsi[3] = "Buku";
            intNomorProduk[3] = 917;
            decHarga[3] = 79900D;

            //Produk kelimat
            strNamaProduk[4] = "Pemrograman C++";
            strDeskripsi[4] = "CD";
            intNomorProduk[4] = 918;
            decHarga[4] = 90500D;
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void masukkanDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intHitung = 0; //kounter loop
            while (intHitung < intSUBSKRIP_MAKS)
            {
                try
                {
                    //Membaca jumlah unit terjual atas sebuah produk
                    //Membaca penjualan
                    int nilaiMasukan = 0;
                    if (InputBox("Masukkan Jumlah Unit Terjual", "Nomor Produk:" +
                        intNomorProduk[intHitung].ToString(), ref nilaiMasukan) == DialogResult.OK)
                    {
                        intUnitTerjual[intHitung] = nilaiMasukan;
                    }

                    //Menginkremen intHitung
                    intHitung += 1;
                }
                catch
                {
                    //Pesan error karena masukan tak-valid
                    MessageBox.Show("Masukkan integer yang valid");
                }
            }
        }

        private void tampilkanDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menghitung dan menampilkan pendapatan untuk
            //tiap produk dan pendapatan total
            int intHitung;
            double decPendapatan;
            double decPendapatanTotal = 0.0;

            //Menampilkan kepala tabel laporan penjualan.
            kotakList.Items.Add("LAPORAN PENJUALAN");
            kotakList.Items.Add("-------------------");

            //Menampilkan data penjualan untuk tiap produk
            for (intHitung = 0; intHitung < intSUBSKRIP_MAKS; intHitung++)
            {
                //Menghitung pendapatan produk
                decPendapatan = intUnitTerjual[intHitung] * decHarga[intHitung];

                //Menampilkan data produk
                kotakList.Items.Add("Nomor produk: " +
                    intNomorProduk[intHitung]);
                kotakList.Items.Add("Nama: " +
                    strNamaProduk[intHitung]);
                kotakList.Items.Add("Deskripsi: " +
                    strDeskripsi[intHitung]);
                kotakList.Items.Add("Harga Unit: Rp. " +
                    decHarga[intHitung].ToString("N1"));
                kotakList.Items.Add("Jumlah Unit Terjual: " +
                    intUnitTerjual[intHitung].ToString());
                kotakList.Items.Add("Pendapatan Produk: Rp. " +
                    decPendapatan.ToString("N1"));
                kotakList.Items.Add("");

                //Akumulasi pendapatan
                decPendapatanTotal = decPendapatanTotal + decPendapatan;
            }

            //Menampilkan pendapatan total
            teksPendapatan.Text = "Rp. " + decPendapatanTotal.ToString("N1");
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menampilkan menu "Tentang"
            MessageBox.Show("Menampilkan laporan Penjualan Sianipar Corp.", "Tentang");
        }
    }
}
