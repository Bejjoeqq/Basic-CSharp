using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AldhiyaKoneksi
{
    public partial class Konek : Form
    {
        public Konek()
        {
            InitializeComponent();
        }

        private void Konek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'siswasDataSet2.siswatbl' table. You can move, or remove it, as needed.
            this.siswatblTableAdapter.Fill(this.siswasDataSet2.siswatbl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data = "SERVER=localhost;" + "DATABASE=siswas;" + "UID=root;" + "PASSWORD=;";
                MySqlConnection koneksi = new MySqlConnection(data);
                koneksi.Open();
                MessageBox.Show("Koneksi Sukses !!");

                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = "SELECT * FROM siswatbl";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0] + " | " + reader[1] + " | " + reader[2] + " | " + reader[3]);
                }

                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal" + ex.Message);
            }
        }
    }
}
