using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayananChequeDenganStruktur
{
    public struct Orang
    {
        //variabel-variabel anggota privat untuk properti-properti publik
        private string _namadepan;
        private string _namatengah;
        private string _namaakhir;
        private DateTime _dob;


        //anggota privat untuk perhitungan beda waktu---------------
        private TimeSpan _bedawaktu;

        //------------- properti-properti publik ---------------
        public string NamaDepan
        {
            get
            {
                //------------- Ini adalah fungsi ProperCase ---------------
                return HurufBesar(_namadepan);
            }
            set
            {
                _namadepan = value;
            }
        }

        public string NamaTengah
        {
            get
            {
                return HurufBesar(_namatengah);
            }
            set
            {
                _namatengah = value;
            }
        }

        public string NamaAkhir
        {
            get
            {
                return HurufBesar(_namaakhir);
            }
            set
            {
                _namaakhir = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return _dob;
            }
            set
            {
                _dob = value;
            }
        }

        //------------- properti-properti readonly ---------------
        public string NamaPenuh
        {
            get
            {
                return HurufBesar(_namadepan.Trim() + " " + _namatengah.Trim() + " " + _namaakhir.Trim());
            }
        }

        public string NamaCheque
        {
            get
            {
                //menghasilkan BacaNamaCheque()
                return BacaNamaCheque();
            }
        }

        public int Usia
        {
            get
            {
                //menghitung jumlah beda hari
                _bedawaktu = DateTime.Now - DOB;
                return (int)(_bedawaktu.Days / 365);
            }
        }

        //------------- metode-metode ---------------
        private string BacaNamaCheque()
        {
            string strPertamaDanTengah = _namadepan.Trim() + " " + _namatengah.Trim();
            string[] arrayNama = strPertamaDanTengah.ToLower().Split(new Char[] {' '});
            short j;
            string aNama = "";

            //sekarang mengubah nama depan dan nama tengah menjadi huruf besar plus ". "
            for (j = 0; j < (arrayNama.Length); j++)
            {
                aNama = arrayNama[j];
                arrayNama[j] = aNama.ToUpper().Substring(0, 1) + ". ";
            }
            aNama = "";

            //menyambung nama
            foreach (string strPertamaDanTengah2 in arrayNama)
                aNama += strPertamaDanTengah2;

            //menghuruf-besarkan nama akhir
            strPertamaDanTengah = HurufBesar(_namaakhir);
            return aNama.Trim() + " " + strPertamaDanTengah.Trim();
        }

        public string BacaNamaTengah()
        {
            return HurufBesar(_namatengah);
        }

        private string HurufBesar(string strKata)
        {
            //membaca string dan menghuruf-besarkan huruf pertama pada tiap kata
            string[] arrayKata = strKata.Split(new Char[] {' '});
            string temp = ""; string kiri = ""; string kanan = "";

            short j;
            //menjelajah semua kata, membaca huruf pertama, dan menghuruf-besarkannya
            for (j = 0; j < arrayKata.Length; j++)
            {
                temp = arrayKata[j];
                kiri = temp.ToUpper().Substring(0, 1);
                kanan = temp.ToLower().Substring(1, temp.Length - 1);
                arrayKata[j] = kiri + kanan;
            }
            kiri = "";

            foreach (string temp2 in arrayKata)
                kiri += temp2 + " ";

            return kiri.Trim();
        }
    }

    public partial class Form1 : Form
    {
        Orang orangKu;

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolProses_Click(object sender, EventArgs e)
        {
            orangKu.NamaDepan = teksNamaDepan.Text;
            orangKu.NamaTengah = teksNamaTengah.Text;
            orangKu.NamaAkhir = teksNamaAkhir.Text;
            orangKu.DOB = dtpDOB.Value;
            teksKelUsia.Text = orangKu.Usia.ToString();
            teksKelNamaPenuh.Text = orangKu.NamaPenuh;
            teksKelNamaTengah.Text = orangKu.BacaNamaTengah();
            teksKelNamaCheque.Text = orangKu.NamaCheque;
        }
    }
}
