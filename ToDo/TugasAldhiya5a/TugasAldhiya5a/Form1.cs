using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TugasAldhiya5a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboNilai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nim;
            nim = Convert.ToString(cboNilai.Text);
            switch (nim)
            {
                case "A":
                    MessageBox.Show("Bobot 4");
                    break;
                case "B":
                    MessageBox.Show("Bobot 3");
                    break;
                case "C":
                    MessageBox.Show("Bobot 2");
                        break;
                case "D":
                        MessageBox.Show("Bobot 1");
                    break;
                case "E":
                        
                    break;

                    
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            cboNilai.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin mau keluar ?", "QUIT",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
