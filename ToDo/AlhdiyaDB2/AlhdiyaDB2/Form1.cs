using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlhdiyaDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void load()
        {
            string sql = "SELECT * FROM tblPebHdr";
            data.dgv(sql, "",dataGridView1);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txtNim.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtKelas.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cboStudi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO siswatbl value ('" + txtNim.Text + "','" + txtNama.Text + "','" + txtKelas.Text + "','" + cboStudi.Text + "')";

            data.simpan(sql);

            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE siswatbl SET Nama = '" + txtNama.Text + "',Kelas= '" + txtKelas.Text + "', Prodi= '" + cboStudi.Text + "' WHERE NIS='" +
                   txtNim.Text + "'";


            data.ubah(sql);
            load();
        }
        void clear()
        {
            txtNim.Text = "";
            txtNama.Text = "";
            txtKelas.Text = "";
            cboStudi.Text = "";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            data.del("data", "NIS", txtNim);
            load();
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Anda Ingin Keluar?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboStudi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
