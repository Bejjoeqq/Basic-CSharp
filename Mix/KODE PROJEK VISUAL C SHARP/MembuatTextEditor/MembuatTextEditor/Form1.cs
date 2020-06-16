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

namespace MembuatTextEditor
{
    public partial class Form1 : Form
    {
        //Variabel-variabel level-kelas
        private string strNamaFile = string.Empty;  //nama file dokumen
        bool blnApaBerubah = false;     //bendera perubahan file

        public Form1()
        {
            InitializeComponent();
        }

        private void BersihkanDokumen()
        {
            //Membersikan isi dari kotak teks
            teksDokumen.Clear();
            //Membersihkan nama dokumen
            strNamaFile = String.Empty;
            //Menetapkan blnApaBerubah menjadi False
            blnApaBerubah = false;
        }

        //Prosedur BukaDokumen membuka sebuah file dan memuatnya
        //ke kotak teks
        private void BukaDokumen()
        {
            StreamReader FileMasukan; //Variabel Object
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Membaca nama file
                strNamaFile = openFileDialog1.FileName;
                try
                {
                    //Membuka file
                    FileMasukan = File.OpenText(strNamaFile);
                    //Membaca isi file dan menempatkannya pada kotak teks
                    teksDokumen.Text = FileMasukan.ReadToEnd();
                    //Menutup file
                    FileMasukan.Close();
                    //Memperbarui variabel blnApaBerubah
                    blnApaBerubah = false;
                }
                catch
                {
                    //Pesan error karena error pembukaan file
                    MessageBox.Show("Error pembukaan file.");
                }
            }
        }

        //Prosedur BukaDokumen menyimpan dokumen
        private void SimpanDokumen()
        {
            StreamWriter FileKeluaran; //Variabel Object
            try
            {
                //Menciptakan file
                FileKeluaran = File.CreateText(strNamaFile);
                //Menuliskan kotak teks ke file
                FileKeluaran.Write(teksDokumen.Text);
                //Menutup file
                FileKeluaran.Close();
                //Memperbarui blnApaBerubah
                blnApaBerubah = false;
            }
            catch
            {
                //Pesan error untuk error penciptaan file
                MessageBox.Show("Error penciptaan file.");
            }
        }

        private void teksDokumen_TextChanged(object sender, EventArgs e)
        {
            //Mengindikasikan bahwa teks telah berubah
            blnApaBerubah = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Apakah dokumen berubah?
            if (blnApaBerubah == true)
            {
                //Memastikan sebelum menghapus dokumen
                if ((MessageBox.Show("Dokumen belum disimpan. " +
                    "Anda yakin?", "Memastikan", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes))
                    BersihkanDokumen();
            }
            else
                //Dokumen tidak berubah, jadi dihapus
                BersihkanDokumen();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Apakah dokumen berubah?
            if (blnApaBerubah == true)
            {
                //Memastikan sebelum menghapus dokumen
                if ((MessageBox.Show("Dokumen belum disimpan. " +
                    "Anda yakin?", "Memastikan", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes))
                    BersihkanDokumen();
            }
            else
            {
                //Dokumen tidak berubah, jadi diganti
                BersihkanDokumen();
                BukaDokumen();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Apakah dokumen sudah punya nama file?
            if (strNamaFile == String.Empty)
            {
                //Dokumen belum disimpan, jadi
                //menggunakan SaveFileDialog
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    strNamaFile = saveFileDialog1.FileName;
                    SimpanDokumen();
                }
            }
            else
                //Menyimpan dokumen dengan nama file yang telah ada
                SimpanDokumen();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menyimpan dokumen dengan nama baru
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strNamaFile = saveFileDialog1.FileName;
                SimpanDokumen();
            }


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menampilkan menu tentang
            MessageBox.Show("Text Editor Sederhana versi 1.0");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Jika dokumen belum berubah, memastikan sebelum keluar
            if (blnApaBerubah == true)
            {
                if (MessageBox.Show("Dokumen belum disimpan. " +
                    "Apakah Anda ingin mengabaikan perubahan dokumen?",
                    "Memastikan",
                    MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }
    }
}
