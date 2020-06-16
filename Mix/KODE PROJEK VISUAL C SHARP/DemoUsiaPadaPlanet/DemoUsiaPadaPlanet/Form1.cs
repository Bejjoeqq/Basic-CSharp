using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUsiaPadaPlanet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            Double usiaPdPlanet = 0, usiaHariBumi, usiaTahunBumi;
            DateTime dt;
            dt = DateTime.Parse(maskedUltah.Text);
            String nom = "";
            bool tdkRespon = false;
            teksToday.Text = DateTime.Today.ToString();
            usiaHariBumi = (DateTime.Today.Subtract(dt)).Days;
            usiaTahunBumi = usiaHariBumi / 365.26;

            if (radMerkurius.Checked) {
                usiaPdPlanet = usiaHariBumi / 88;
                nom = " Mercurian ";
            }
            else if (radVenus.Checked){
                usiaPdPlanet = usiaHariBumi / 224.7;
                nom = " Venusian ";
            }
            else if (radBumi.Checked){
                usiaPdPlanet = usiaTahunBumi;
                nom = " Bumi ";
            }
            else if (radMars.Checked) {
                usiaPdPlanet = usiaHariBumi / 687;
                nom = " Martian ";
            }
            else if (radJupiter.Checked) {
                usiaPdPlanet = usiaTahunBumi / 11.86;
                nom = " Jovian ";
            }
            else if (radSaturnus.Checked) {
                usiaPdPlanet = usiaTahunBumi / 29.46;
                nom = " Saturian ";
            }
            else if (radUranus.Checked) {
                usiaPdPlanet = usiaTahunBumi / 84.07;
                nom = " Uranian ";
            }
            else if (radNeptunus.Checked) {
                usiaPdPlanet = usiaTahunBumi / 164.8;
                nom = " Neptunian ";
            }
            else {
                tdkRespon = true;
            }
            if (tdkRespon)
                MessageBox.Show("Anda harus memilih satu planet.");
            else
                teksUsiaHari.Text = usiaPdPlanet.ToString("N1") +
                    " tahun " + nom + ".";
        }
    }
}