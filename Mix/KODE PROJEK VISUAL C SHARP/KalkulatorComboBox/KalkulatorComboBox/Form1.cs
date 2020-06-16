using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            Double angka1, angka2, hasil;
            if ((teks1.Text == "") || (teks2.Text == ""))
                MessageBox.Show("Operand Kosong");
            else {
                if (kotakKombo.SelectedIndex == -1)
                    MessageBox.Show("Operator tidak dipilih");
                else if (kotakKombo.SelectedIndex == 0) {
                    angka1 = Double.Parse(teks1.Text);
                    angka2 = Double.Parse(teks2.Text);
                    hasil = angka1 + angka2;
                    teksHasil.Text = hasil.ToString();
                }
                else if (kotakKombo.SelectedIndex == 1) {
                    angka1 = Double.Parse(teks1.Text);
                    angka2 = Double.Parse(teks2.Text);
                    hasil = angka1 - angka2;
                    teksHasil.Text = hasil.ToString ();
                }
                else if (kotakKombo.SelectedIndex == 2) {
                    angka1 = Double.Parse(teks1.Text);
                    angka2 = Double.Parse(teks2.Text);
                    hasil = angka1 * angka2;
                    teksHasil.Text = hasil.ToString ();
                }
                else if (kotakKombo.SelectedIndex == 3) {
                    angka1 = Double.Parse(teks1.Text);
                    angka2 = Double.Parse(teks2.Text);
                    hasil = angka1 / angka2;
                    teksHasil.Text = hasil.ToString ();
                }
            }
        }
    }
}
