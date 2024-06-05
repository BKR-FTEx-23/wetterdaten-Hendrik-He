using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WetterdatenHeHe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Wetterdaten liste1 = new Wetterdaten(1);

        private void btnAuswerten_Click(object sender, EventArgs e)
        {

        }

        private void btnSpeichernEingabe_Click(object sender, EventArgs e)
        {
            Wetter data = Eingabe();
            liste1.AddWetterdaten(data);
            txtAusgabe.Text = liste1.ToString();
        }

        private void btnSpeichernDatei_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string dateiname = saveFileDialog1.FileName;
            liste1.DateiSpeichern(dateiname);
            MessageBox.Show("Datei abgespeichert");
            txtAusgabe.Text = liste1.ToString();
        }

        private void btnEinlesenDatei_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string dateiname = openFileDialog1.FileName;
            liste1.DateiEinlesen(dateiname);
            MessageBox.Show("Datei eingelesen");
            txtAusgabe.Text = liste1.ToString() ;
        }

        public Wetter Eingabe()
        {
            Wetter data;
            try
            {
                DateTime datum = dtpDatenEingabe.Value;
                double temperatur = double.Parse(txtTempEingabe.Text.Replace(",", "."));
                double luftfeuchtigkeit = double.Parse(txtLuftfEingabe.Text.Replace(",", "."));

                data = new Wetter(datum, temperatur, luftfeuchtigkeit);
                return data;
            }
            catch
            {
                MessageBox.Show("Daten eingegeben");
                return null;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
