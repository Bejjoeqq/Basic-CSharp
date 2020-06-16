using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPenggajianSederhana
{
    public partial class Form1 : Form
    {
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

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            //Konstanta-konstanta
            const double decGAJI_PER_JAM = 70000D;
            const int intSUBSKRIP_MAKS = 5;

            //Array dan variabel-variabel lain
            double[] dblArrayJam = new double[intSUBSKRIP_MAKS];
            int intHitung = 0; //Kounter loop
            double decGaji_Kotor;  //memuat gaji kotor

            //Meminta pengguna untuk memasukkan jumlah jam kerja tiap karyawan
            MessageBox.Show("Saya meminta Anda untuk memasukkan jumlah" +
                "jam kerja dari tiap karyawan.");

            //Membaca jumlah jam kerja dari tiap karyawan
            while (intHitung < dblArrayJam.Length)
            {
                try
                {
                    int nilaiMasukan = 0;
                    if (InputBox("Masukkan Nomor Karyawan", "Nomor Karyawan:" + 
                        (intHitung + 1).ToString(), ref nilaiMasukan) == DialogResult.OK)
                    {
                        dblArrayJam[intHitung] = nilaiMasukan;
                    }
                    intHitung += 1;
                }
                catch
                {
                    //Menampilkan pesan error
                    MessageBox.Show("Masukkan jumlah jam kerja " +
                        "yang valid untuk karyawan.");
                }
            }

            //Membersihkan kotak list
            kotakList.Items.Clear();

            //Menghitung dan menampilkan gaji kotor tiap karyawan
            for (intHitung = 0; intHitung <dblArrayJam.Length; intHitung++)
            {
                decGaji_Kotor = (dblArrayJam[intHitung] * decGAJI_PER_JAM);
                kotakList.Items.Add("Karyawan " + (intHitung + 1).ToString() +
                    " mendapatkan gaji Rp. " +
                    decGaji_Kotor.ToString("N"));
            }
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}