using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace WetterdatenHeHe
{
    public class Wetterdaten
    {
        public List<Wetter> ListeWetterdaten;
        public int ID { get; set; }

        
        public Wetterdaten(int id)
        {
            this.ID = id;
            ListeWetterdaten = new List<Wetter>();
        }

        public void AddWetterdaten(Wetter datum)
        {
            ListeWetterdaten.Add(datum);
        }
        public void DateiEinlesen(string dateiname)
        {
            StreamReader datei = new StreamReader(dateiname);

            if (File.Exists(dateiname))
            {
                //Ignoriert Überschrift
                datei.ReadLine();
                while (!datei.EndOfStream)
                {
                    var zeile = datei.ReadLine();
                    var werte = zeile.Split(';');

                    DateTime datum = DateTime.Parse(werte[0]);
                    double temperatur = double.Parse(werte[1].Replace(",", "."));
                    double luftfeuchtigkeit = double.Parse(werte[2].Replace(",", "."));

                    Wetter data = new Wetter(datum, temperatur, luftfeuchtigkeit);
                    ListeWetterdaten.Add(data);
                }
            }
            datei.Close();
        }
        public void DateiSpeichern(string dateiname)
        {
            using (StreamWriter datei = new StreamWriter(dateiname))
            {
                string zeile = ListeWetterdaten.ToString();
                datei.WriteLine(zeile);
            }
        }
        public void Auswertung(List<Wetterdaten> liste)
        {
            List<Wetter> tempListe = new List<Wetter>();
            foreach(var daten in liste)
            {
                tempListe.Add(daten);
            }
            WetterAuswertung auswertung = new WetterAuswertung();
            auswertung.BerechneDurchschnittTemp();

        }
        public override string ToString()
        {
            string liste = "Datum | Temperatur | Luftfeuchtigkeit" + System.Environment.NewLine;
            foreach (var data in ListeWetterdaten)
            {
                liste += $"{data}" + System.Environment.NewLine;
            }
            return liste;
        }

    }
}
