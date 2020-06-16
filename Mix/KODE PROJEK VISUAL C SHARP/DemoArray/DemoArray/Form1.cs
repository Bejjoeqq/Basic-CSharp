using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoArray
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

        private void tombolMasuk_Click(object sender, EventArgs e)
        {
            const int intSUBSKRIP_MAKS = 6;
            string[] strNama = new string[intSUBSKRIP_MAKS]; //Array untuk memuat nama-nama
            int intHitung; //Kounter loop

            //Memberitahu pengguna apa yang perlu dilakukan
            MessageBox.Show("Saya meminta Anda untuk memasukkan " +
                "nama dari lima teman Anda.");

            //Membaca nama dan menyimpannya di dalam array
            for (intHitung = 0; intHitung < intSUBSKRIP_MAKS; intHitung++)
            {
                string strMasukan = "";
                if (InputBox("Masukkan Nama Teman Anda", "Nama Teman:", ref strMasukan) == DialogResult.OK)
                {
                    strNama[intHitung] = strMasukan;
                }
            }

            //Membersihkan kotak list
            kotakList.Items.Clear();
            //Menampilkan isi array pada kotak list
            for (intHitung = 0; intHitung < intSUBSKRIP_MAKS; intHitung++) 
                kotakList.Items.Add(strNama[intHitung]);
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
