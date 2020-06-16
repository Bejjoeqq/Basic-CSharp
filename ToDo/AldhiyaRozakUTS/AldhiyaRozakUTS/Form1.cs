using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaRozakUTS
{
    public partial class Form1 : Form
    {
        string nama, program, stambuk, no;
        double spp, dka, potongan,total;
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNim.Text == "13012001")
            {
                nama = "Andi";
                program = "Manajemen Informatika";
                stambuk = "2013";
                no = "001";
            }
            else if(cboNim.Text=="13012002")
            {
                nama = "Adi";
                program = "Manajemen Informatika";
                stambuk = "2013";
                no = "002";
            }
            else if (cboNim.Text == "13012003")
            {
                nama = "Abi";
                program = "Manajemen Informatika";
                stambuk = "2013";
                no = "003";
            }
            else if (cboNim.Text == "13012004")
            {
                nama = "Ani";
                program = "Manajemen Informatika";
                stambuk = "2013";
                no = "004";
            }
            else if (cboNim.Text == "13012005")
            {
                nama = "Ardi";
                program = "Manajemen Informatika";
                stambuk = "2013";
                no = "005";
            }
            else if (cboNim.Text == "14013006")
            {
                nama = "Budi";
                program = "Teknik Informatika";
                stambuk = "2014";
                no = "006";
            }
            
            else if (cboNim.Text == "14013007")
            {
                nama = "Badu";
                program = "Teknik Informatika";
                stambuk = "2014";
                no = "007";
            }

            else if (cboNim.Text == "14013008")
            {
                nama = "Beti";
                program = "Teknik Informatika";
                stambuk = "2014";
                no = "008";
            }
            else if (cboNim.Text == "14013009")
            {
                nama = "Bernard";
                program = "Teknik Informatika";
                stambuk = "2014";
                no = "009";
            }
            else if (cboNim.Text == "14013010")
            {
                nama = "Baihaqi";
                program = "Teknik Informatika";
                stambuk = "2014";
                no = "010";
            }
            else if (cboNim.Text == "15014011")
            {
                nama = "Cici";
                program = "Akutansi";
                stambuk = "2015";
                no = "011";
            }
            else if (cboNim.Text == "15014012")
            {
                nama = "Cacah";
                program = "Akutansi";
                stambuk = "2015";
                no = "012";
            }
            else if (cboNim.Text == "15014013")
            {
                nama = "Cindy";
                program = "Akutansi";
                stambuk = "2015";
                no = "013";
            }
            else if (cboNim.Text == "15014014")
            {
                nama = "Cahyo";
                program = "Akutansi";
                stambuk = "2015";
                no = "014";
            }
            else if (cboNim.Text == "15014015")
            {
                nama = "Caisar";
                program = "Akutansi";
                stambuk = "2015";
                no = "015";
            }
            else
            {
                MessageBox.Show("Masukkan Nim","Perhtikan Kembali");
            }
            txtNama.Text = nama;
            txtProgram.Text = program;
            txtStambuk.Text = stambuk;
            txtNou.Text = no;
        }

        private void cboPaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaket.Text == "REGULER")
            {
                spp = 4500000;
                dka = 2000000;
            }
            else if (cboPaket.Text == "KARYAWAN")
            {
                spp = 5000000;
                dka = 3000000;
            }
            txtSPP.Text = "Rp." + spp.ToString("N");
            txtDKA.Text = "Rp." + dka.ToString("N");
        }

        private void cboTahap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTahap.Text == "1")
            {
                potongan = spp * 10 / 100;
            }
            else if (cboTahap.Text == "2")
            {
                potongan = spp * 5 / 100;
            }
            else if (cboTahap.Text == "3")
            {
                potongan = 0;
            }
            txtPotongan.Text ="Rp." + potongan.ToString("N");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDKA.Text = "";
            txtNama.Text = "";
            txtNou.Text = "";
            txtPotongan.Text = "";
            txtProgram.Text = "";
            txtSPP.Text = "";
            txtStambuk.Text = "";
            txtTotal.Text = "";
            cboNim.Text = "";
            cboPaket.Text = "";
            cboTahap.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin Mau Keluar ?", "Exit",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            total = spp + dka - potongan;
            txtTotal.Text = "Rp." + total.ToString("N");
        }
    }
}
