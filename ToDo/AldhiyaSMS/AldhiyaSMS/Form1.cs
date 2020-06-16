using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;

namespace AldhiyaSMS
{
    public partial class Form1 : Form
    {
        GsmCommMain comm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int noPortCom = 3;
            int bauRate = 9600;
            comm = new GsmCommMain(noPortCom, bauRate);
            comm.Open();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            try
            {
                SmsSubmitPdu pdu;
                pdu = new SmsSubmitPdu(rchPesan.Text, txtHP.Text,"");
                comm.SendMessage(pdu);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            comm.Close();
        }
    }
}
