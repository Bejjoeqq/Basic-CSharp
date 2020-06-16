using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RerataLoopWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool ApaNumerik(string masukan)
        {
            int uji;
            return int.TryParse(masukan, out uji);
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
            //Prosedur ini membaca skor, kemudian menghitung dan
            //menampilkan rerata
            Int16 intBanyakSkor = 0; //Banyaknya skor
            Double dblSkorUji = 0.0; //menampung skor uji
            Double dblTotal = 0.0;   //akumulator, diinisialisasi dengan 0
            Double dblRerata = 0.0;  //Rerata dari skor-skor uji
            Int16 intKounter = 1; //variabel kounter, diinisialisasi dengan 1

            //Meminta pengguna memasukkan banyaknya skor
            string strMasukan = "";
     
            if (InputBox("Masukkan Banyak Skor", "Banyak Skor:", ref strMasukan) == DialogResult.OK)
            {
                teksRerata.Name = strMasukan;
            }

            //Apakah masukan integer
            if (ApaNumerik(strMasukan))
            {
                intBanyakSkor = Int16.Parse(strMasukan);
                //Membaca skor uji
                while (intKounter > intBanyakSkor) {
                    //Meminta pengguna memasukkan skor
                    string strSkor = "";

                    if (InputBox("Masukkan Skor", "Skor:", ref strSkor) == DialogResult.OK)
                    {
                        teksRerata.Name = strSkor;
                    }

                    //Konversi masukan menjadi sebuah Double.
                    if (ApaNumerik(teksRerata.Text))
                    {
                        dblSkorUji = Int16.Parse(teksRerata.Text);
                        //Menambahkan skor pada akumulator
                        dblTotal += dblSkorUji;
                        //Menambahkan 1 pada kounter
                        intKounter += 1;
                    }
                    else
                        //skor uji tak-valid
                        MessageBox.Show("Masukkan skor uji numerik");
                }

                //Menghitung dan menampilkan rerata
                if (intBanyakSkor > 0) {
                    dblRerata = dblTotal / intBanyakSkor;
                    teksRerata.Text = dblRerata.ToString();
                }
                //Banyak skor uji tak-valid
                MessageBox.Show("Masukkan nilai integer");
            }
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
