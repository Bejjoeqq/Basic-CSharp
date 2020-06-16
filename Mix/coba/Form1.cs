using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace coba
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommandBuilder cmb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string data = "SERVER=localhost;" + "DATABASE=siswas;" + "UID=root;" + "PASSWORD=;";
            conn = new MySqlConnection(data);
            da = new MySqlDataAdapter("select * from siswatbl",conn);
            ds = new System.Data.DataSet();
            da.Fill(ds, "Bejjo");
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb = new MySqlCommandBuilder(da);
            da.Update(ds, "Bejjo");
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
