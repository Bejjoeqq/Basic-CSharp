using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MembacaDataDariFile
{
    public partial class Form1 : Form
    {
        //Konstanta level-kelas untuk nama file
        private const string strNAMAFILE = "Angka.txt";

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
            textBox.Text = nilai.ToString(); ;
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

        private void tombolCiptakan_Click(object sender, EventArgs e)
        {
            //Variabel-variabel lokal
            StreamWriter FileKeluaran;  //Variabel Objecct
            int intJumMaks = 0;         //Jumlah nilai
            int intHitung = 0;          //Kounter loop, ditetapkan 0
            int intAngka = 0;           //Memuat masukan pengguna

            try
            {
                //Membaca angka-angka dari pengguna

                int jumMaks = 0;
                if (InputBox("Berapa Banyak Integer", "Banyak Integer:", ref jumMaks) == DialogResult.OK)
                {
                    intJumMaks = jumMaks;
                }

                try
                {
                    //Menciptakan file
                    FileKeluaran = File.CreateText(strNAMAFILE);
                    //Membaca angka-angka dan menuliskan ke file
                    while (intHitung < intJumMaks)
                    {
                        try
                        {
                            int angka = 0;
                            if (InputBox("Masukkan Integer", "Integer:", ref angka) == DialogResult.OK)
                            {
                                intAngka = angka;
                            }

                            //Menuliskan integer tersebut ke dalam file
                            FileKeluaran.WriteLine(intAngka);
                            //Menginkremen intHitung
                            intHitung += 1;
                        }
                        catch
                        {
                            //Pesan error untuk integer tak-valid
                            MessageBox.Show("Nilai terakhir yang Anda masukkan bukanlah" +
                                " sebuah integer yang valid. Coba lagi.");
                        }
                    }
                    //Menutup file
                    FileKeluaran.Close();
                }
                catch
                {
                    //Pesan error untuk error penciptaan file
                    MessageBox.Show("Error penciptaan file " + strNAMAFILE);
                }
            }
            catch
            {
                //Pesan error untuk angka tak-valid
                MessageBox.Show("Silahkan masukkan integer yang valid");
            }
        }

        private void tombolBaca_Click(object sender, EventArgs e)
        {
            //Variabel-variabel lokal
            StreamReader FileMasukan;   //Variabel Object
            string strMasukan;          //Untuk memuat sebaris masukan

            try
            {
                //Membuka file
                FileMasukan = File.OpenText(strNAMAFILE);

                //Membersihkan kotak list
                kotakList.Items.Clear();

                //Membaca isi file
                while (FileMasukan.EndOfStream == false)
                {
                    //Membaca sebaris dari file
                    strMasukan = FileMasukan.ReadLine();
                    //Menampilkan sebaris masukan pada kotak list
                    kotakList.Items.Add(strMasukan);
                }
                //Menutup file
                FileMasukan.Close();
            }
            catch{
                //Pesan error untuk error pembukaan file
                MessageBox.Show(strNAMAFILE + " tidak dapat dibuka");
            }
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}