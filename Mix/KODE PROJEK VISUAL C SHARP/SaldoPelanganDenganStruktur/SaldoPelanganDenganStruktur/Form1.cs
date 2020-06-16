using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaldoPelanganDenganStruktur
{
    public struct Pelanggan
    {
        public string NamaDepan;
        public string NamaBlkg;
        public string NoAkun;
        public double Deposito;
        public double Pinjaman;
        private double _saldo;

        //Properti Saldo
        public double Saldo
        {
            get
            {
                _saldo += Deposito - Pinjaman;
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        //Properti Nama
        public string Nama
        {
            get { return NoAkun + " " + NamaDepan + " " + NamaBlkg;}
        }

        //Properti Email
        public string Email
        {
            get { return NamaDepan + "-" + NamaBlkg + "@SianiparCollege.ac.id";}
        }
    }

    public partial class Form1 : Form
    {
        Pelanggan pelangganKu = new Pelanggan();

        public Form1()
        {
            InitializeComponent();
        }

        private void tombolDaftar_Click(object sender, EventArgs e)
        {
            pelangganKu.NamaDepan = teksNamaDepan.Text;
            pelangganKu.NamaBlkg = teksNamaBlkg.Text;
            pelangganKu.NoAkun = teksNoAkun.Text;
            pelangganKu.Deposito = double.Parse(teksDeposito.Text);
            pelangganKu.Pinjaman = double.Parse(teksPinjaman.Text);

            //Menampilkan konsumen
            TampilPelanggan(pelangganKu);
        }

        public void TampilPelanggan(Pelanggan pelanggan)
        {
            //Menampilkan identitas pelanggan pada form
            teksSaldoAkhir.Text = pelangganKu.Saldo.ToString("N");
            teksEmail.Text = pelanggan.Email;
            teksNama.Text = pelanggan.Nama;
            kotakList.Items.Add(pelanggan.Nama + " " + pelanggan.Saldo.ToString("N"));
        }

        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}