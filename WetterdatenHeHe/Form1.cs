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
        //done
        Wetterdaten datensammlung1 = new Wetterdaten(1);

        private void btnAuswerten_Click(object sender, EventArgs e)
        {
            try
            {
                lblDurchschnittTemp.Text = $"Durchschnitttemperatur: {datensammlung1.BerechneDurchschnittTemp():#.##}";
                lblDurchschnittLuft.Text = $"Durchschnittsluftfeuchtigkeit: {datensammlung1.BerechneDurchschnittLuft():#.##}";
                lblMinTemp.Text = $"Minimaltemperatur: {datensammlung1.BerechneMinTemp()}";
                lblMaxTemp.Text = $"Maximaltemperatur: {datensammlung1.BerechneMaxTemp()}";
                lbl0bis10.Text = $"0-10°C Tage: {datensammlung1.WerteGruppieren(10, 0)}";
                lbl10bis20.Text = $"10-20°C Tage: {datensammlung1.WerteGruppieren(20, 10)}";
                lbl20bis30.Text = $"20-30°C Tage: {datensammlung1.WerteGruppieren(30, 20)}";
                lblTageLuft.Text = $"Tage mit Luftfeuchtigkeit >79%: {datensammlung1.LuftHoeherX(79)}";
            }
            catch 
            {
                MessageBox.Show("Keine Werte in der Liste");
            }
        }

        private void btnSpeichernEingabe_Click(object sender, EventArgs e)
        {
            Wetter data = Eingabe();//"data{datum,temperatur,luftfeuchtigkeit}" "data={1.1.2011,20.34,30.22}"
            datensammlung1.AddWetterdaten(data);
            txtAusgabe.Text = datensammlung1.ToString();
        }

        private void btnSpeichernDatei_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string dateiname = saveFileDialog1.FileName;
            datensammlung1.DateiSpeichern(dateiname);//.....\downloads\wetter.csv
            MessageBox.Show("Datei abgespeichert");
            txtAusgabe.Text = datensammlung1.ToString();
        }

        private void btnEinlesenDatei_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string dateiname = openFileDialog1.FileName;
            datensammlung1.DateiEinlesen(dateiname);//.....\downloads\wetter.csv
            MessageBox.Show("Datei eingelesen");
            txtAusgabe.Text = datensammlung1.ToString() ;
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
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch
            {
                MessageBox.Show("Syntaxfehler");
                return null;
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
