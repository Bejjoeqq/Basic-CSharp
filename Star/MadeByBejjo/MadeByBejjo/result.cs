using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace MadeByBejjo
{
    public partial class result : Form
    {
        [DllImport("wininet.dll")]
        public static extern int SetForegroundWindow(IntPtr point);
        public result()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(richTextBox1.Text);
            Application.Exit();
        }
    }
}
