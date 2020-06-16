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

        private void tombolBaca_Click(object sender, EventArgs e)
        {
            //Konstanta untuk jumlah sahabat
            const int intJUM_SAHABAT = 3;

            //Variabel-variabel lokal
            StreamReader FileSahabat;    //variabel objek
            string strNamaFile = "";     //Nama file
            string strSahabat = "";      //Nama sahabat
            string strTelepon = "";      //Menampung nomor telepon
            int intHitung;       //Kounter loop

            string strMasukan = "";
            if (InputBox("Masukkan Nama File", "Nama File:", ref strMasukan) == DialogResult.OK)
            {
                strNamaFile = strMasukan;
            }

            try
            {
                //Membuka file
                FileSahabat = File.OpenText(strNamaFile);

                //Membaca data
                for (intHitung = 1; intHitung < (intJUM_SAHABAT+1); intHitung++)
                {
                    //Mambaca nama dan no telp dari file
                    strSahabat = FileSahabat.ReadLine();
                    strTelepon = FileSahabat.ReadLine();

                    //Menampilkan data pada kotak list
                    kotakList.Items.Add("Nomor Sahabat " + intHitung.ToString());
                    kotakList.Items.Add("Nama: " + strSahabat);
                    kotakList.Items.Add("Telpon: " + strTelepon);
                    kotakList.Items.Add(""); //Baris kosong
                }
                //Menutup file
                FileSahabat.Close();
            }
            catch 
            {
                MessageBox.Show("File tidak dapat dibuka");
            }

        }

        private void tombolBersih_Click(object sender, EventArgs e)
        {
            //Membersihkan kotak list
            kotakList.Items.Clear();
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
