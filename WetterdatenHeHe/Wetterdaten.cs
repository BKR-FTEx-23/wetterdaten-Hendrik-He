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
                datei.WriteLine("Datum;Temperatur;Luftfeuchtigkeit");
                foreach (var zeile in ListeWetterdaten)
                {
                    datei.WriteLine(zeile);
                }
            }
        }
        /*
         * Ab hier fangen die Berechnungen an:
        */
        public double BerechneDurchschnittTemp()
        {
            //einfacher: avgTemp = liste.Average(x => x.Temperatur);
            double avgTemp;
            double summeTemperatur = 0;
            int anzahl = ListeWetterdaten.Count;

            foreach (var daten in ListeWetterdaten)
            {
                summeTemperatur += daten.Temperatur;
            }
            return avgTemp = summeTemperatur / anzahl;
        }
        public double BerechneDurchschnittLuft()
        {
            //einfacher: avgLuft = liste.Average(x => x.Luftfeuchtigkeit);
            double avgH;
            double summeLuftfeuchtigkeit = 0;
            int anzahl = ListeWetterdaten.Count;

            foreach (var daten in ListeWetterdaten)
            {
                summeLuftfeuchtigkeit += daten.Luftfeuchtigkeit;
            }
            return avgH = summeLuftfeuchtigkeit / anzahl;
        }
        public double BerechneMinTemp()
        {
            //einfacher: var minTemp = liste.Min(x => x.Temperatur);
            double minTemp = ListeWetterdaten[0].Temperatur;

            foreach (var daten in ListeWetterdaten)
            {
                if (daten.Temperatur < minTemp)
                {
                    minTemp = daten.Temperatur;
                }
            }
            return minTemp;
        }
        public double BerechneMaxTemp()
        {
            double maxTemp = ListeWetterdaten[0].Temperatur;

            foreach (var daten in ListeWetterdaten)
            {
                if (daten.Luftfeuchtigkeit > maxTemp)
                {
                    maxTemp = daten.Temperatur;
                }
            }
            return maxTemp;
        }
        public int WerteGruppieren(int obereGrenze, int untereGrenze)
        {
            int anzahl = 0;
            foreach (var daten in ListeWetterdaten)
            {
                if (daten.Temperatur < obereGrenze && daten.Temperatur > untereGrenze)
                {
                    anzahl++;
                }
            }
            return anzahl;
        }
        public int LuftHoeherX(int x)
        {
            int anzahl = 0;
            foreach (var daten in ListeWetterdaten)
            {
                if (daten.Luftfeuchtigkeit > x)
                {
                    anzahl++;
                }
            }
            return anzahl;
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
