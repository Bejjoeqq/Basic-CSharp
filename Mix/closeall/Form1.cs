using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace closeall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process me = Process.GetCurrentProcess();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.Id != me.Id && IntPtr.Zero != p.MainWindowHandle && false == p.ProcessName.Equals("explorer", StringComparison.CurrentCultureIgnoreCase))
                {
                    // Sends WM_CLOSE; less gentle methods available too.
                    p.CloseMainWindow();
                }
            }
        }
    }
}
