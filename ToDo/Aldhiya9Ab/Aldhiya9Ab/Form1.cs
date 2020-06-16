using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya9Ab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPlay_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer song = new WMPLib.WindowsMediaPlayer();
            song.URL = a;
            if (btnPlay.Text == "Play Music")
            {
                try
                {
                    song.controls.play();
                    btnPlay.Text = "Stop Music";
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnPlay.Text == "Stop Music")
            {
                song.controls.stop();
                btnPlay.Text = "Play Music";
            }
        }
        string a;
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "WAV Files (*.wav)|*.wav|MP3 Files (*.mp3)|*.mp3|All files (*.*)|*.*";
            dlg.InitialDirectory = @"C\Windows\Media";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string pic = dlg.FileName.ToString();
                a = pic;
                txtlokasi.Text = a.ToString();
            }
        }
    }
}