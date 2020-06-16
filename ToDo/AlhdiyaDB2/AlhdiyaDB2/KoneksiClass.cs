using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace AlhdiyaDB2
{
    class KoneksiClass
    {
        static string conn;
        public static MySqlConnection konek
        {
            get
            {
                return new MySqlConnection(conn);
            }
        }
        static KoneksiClass()
        {
            string con = "SERVER=localhost;" + "DATABASE=siswas;" + "UID=root;" + "PASSWORD=;";
            try
            {
                conn = con;
                MessageBox.Show("Koneksi ke database sukses!!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal" + ex.Message);
            }
        }
    }
    public static class data
    {
        static MySqlConnection conn;
        static MySqlDataAdapter da;
        static MySqlCommand cmd;

        public static void dgv(string query, string table, DataGridView dgv)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            conn = KoneksiClass.konek;

            da = new MySqlDataAdapter(query, conn);
            try
            {
                conn.Open();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        public static int simpan(string query)
        {
            conn = KoneksiClass.konek;
            cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return i;
            }

            catch (MySqlException e)
            {
                return 0;
            }
            finally
            {

                conn.Close();

            }
        }

        public static void ubah(string query)
        {
            try
            {
                conn = KoneksiClass.konek;
                conn.Open();

                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Diubah!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public static void hapus(string table, string field, TextBox box)
        {
            if (box.Text == "")
            {
                MessageBox.Show("Pilih Data Yang akan dihapus", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                try
                {
                    string sql = "DELETE FROM siswa WHERE " + field + " = " + box.Text + "";

                    conn = KoneksiClass.konek;
                    conn.Open();
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Dihapus", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }


        }
        public static void del(string table, string field, TextBox box)
        {
            if (box.Text == "")
            {
                MessageBox.Show("Pilih Data Yang akan dihapus", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                try
                {
                    string sql = "DELETE FROM siswatbl WHERE " + field + " = " + box.Text + "";

                    conn = KoneksiClass.konek;
                    conn.Open();
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Dihapus", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}