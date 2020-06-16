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

namespace MenulisDataKeFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void tombolCiptakan_Click(object sender, EventArgs e)
        {
            //Konstanta untuk jumlah sahabat
            const int intJUM_SAHABAT = 3;

            //Variabel-variabel lokal
            string strNamaFile = "";     //Nama file
            string strSahabat = "";       //Nama sahabat
            string strTelepon = "";      //Menampung nomor telepon
            int intHitung;       //Kounter loop
            
            StreamWriter FileSahabat; //Variabel objek StreamWriter

            string strMasukan = "";
            if (InputBox("Masukkan Nama File", "Nama File:", ref strMasukan) == DialogResult.OK)
            {
                strNamaFile = strMasukan;
            }

            try 
            {
                //Membuka file
                FileSahabat = File.CreateText(strNamaFile);

                //Membaca data dan menyimpannya ke dalam file
                for (intHitung = 1; intHitung < (intJUM_SAHABAT + 1); intHitung++)
                {
                    //Membaca nama sahabat
                    string strMasukan2 = "";
                    if (InputBox("Masukkan Nama Sahabat", "Nama Sahabat Ke:" + intHitung.ToString(), ref strMasukan2) == DialogResult.OK)
                    {
                        strSahabat = strMasukan2;
                    }

                    //Membaca nomor telepon sahabat
                    //Membaca nama sahabat
                    string strMasukan3 = "";
                    if (InputBox("Masukkan Nomor Telepon", "Nomor Telepon:" + intHitung.ToString(), ref strMasukan3) == DialogResult.OK)
                    {
                        strTelepon = strMasukan3;
                    }

                    //Menuliskan data ke dalam file
                    FileSahabat.WriteLine(strSahabat);
                    FileSahabat.WriteLine(strTelepon);
                }
                // Menutup file
                FileSahabat.Close();
            }
            catch
            {
                //Pesan error
                MessageBox.Show("File tidak dapat diciptakan");
            }
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void tombolTempel_Click(object sender, EventArgs e)
        {
            //Konstanta untuk jumlah sahabat
            const int intJUM_SAHABAT = 2;

            //Variabel-variabel lokal
            string strNamaFile = "";     //Nama file
            string strSahabat = "";       //Nama sahabat
            string strTelepon = "";      //Menampung nomor telepon
            int intHitung;       //Kounter loop

            StreamWriter FileSahabat; //Variabel objek StreamWriter

            string strMasukan = "";
            if (InputBox("Masukkan Nama File", "Nama File:", ref strMasukan) == DialogResult.OK)
            {
                strNamaFile = strMasukan;
            }

            try
            {
                //Membuka file
                FileSahabat = File.AppendText(strNamaFile);

                //Membaca data dan menyimpannya ke dalam file
                for (intHitung = 1; intHitung < (intJUM_SAHABAT + 1); intHitung++)
                {
                    //Membaca nama sahabat
                    string strMasukan2 = "";
                    if (InputBox("Masukkan Nama Sahabat", "Nama Sahabat Ke:" + intHitung.ToString(), ref strMasukan2) == DialogResult.OK)
                    {
                        strSahabat = strMasukan2;
                    }

                    //Membaca nomor telepon sahabat
                    //Membaca nama sahabat
                    string strMasukan3 = "";
                    if (InputBox("Masukkan Nomor Telepon", "Nomor Telepon:" + intHitung.ToString(), ref strMasukan3) == DialogResult.OK)
                    {
                        strTelepon = strMasukan3;
                    }

                    //Menuliskan data ke dalam file
                    FileSahabat.WriteLine(strSahabat);
                    FileSahabat.WriteLine(strTelepon);
                }
                // Menutup file
                FileSahabat.Close();
            }
            catch
            {
                //Pesan error
                MessageBox.Show("File tidak dapat dibuka");
            }
        }
    }
}