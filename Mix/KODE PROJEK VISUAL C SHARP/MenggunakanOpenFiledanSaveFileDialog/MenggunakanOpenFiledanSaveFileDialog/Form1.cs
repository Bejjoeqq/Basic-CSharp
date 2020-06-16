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

namespace MenggunakanOpenFiledanSaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolBuka_Click(object sender, EventArgs e)
        {
            kotakTeks.Text = ""; //membersihkan data pada kotak list
            openFileDialog1.Title = "Silahkan Pilih Sebuah File";
            openFileDialog1.InitialDirectory = "E:";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.Stream strm;  //aliran data
            string strpath;         //path ke file
            string strteks;         //menahan agar file tetap terbuka

            strm = openFileDialog1.OpenFile();

            //menunjukkan path dari file pada form
            teksPath.Text = openFileDialog1.FileName.ToString();
            strpath = openFileDialog1.FileName.ToString();

            if (!strm.Equals(null))
            {
                //membaca data pada file
                try //menyalin data ke kotak list
                {
                    strteks = File.ReadAllText(strpath);
                    kotakTeks.Text = strteks;
                }
                catch
                {
                    MessageBox.Show("Memeriksa apakah nama file tepat");
                }
                strm.Close();  //menutup streamreader
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string FilSimpan = saveFileDialog1.FileName;
            System.IO.StreamWriter objekTulis = new System.IO.StreamWriter(FilSimpan);
            objekTulis.Write(kotakTeks.Text);
            objekTulis.Close();
        }

        private void tombolSimpan_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}