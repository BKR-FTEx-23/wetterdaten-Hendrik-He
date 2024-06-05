using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterdatenHeHe
{
    public class WetterAuswertung
    {
        public double BerechneDurchschnittTemp(List<Wetter> liste)
        {
            //einfacher: avgTemp = liste.Average(x => x.Temperatur);
            double avgTemp;
            double summeTemperatur = 0;
            int anzahl = liste.Count;

            foreach (var daten in liste)
            {
                summeTemperatur += daten.Temperatur;
            }
            return avgTemp = summeTemperatur / anzahl;
        }
        public void BerechneDurchschnittLuft(List<Wetter> liste)
        {
            //einfacher: avgLuft = liste.Average(x => x.Luftfeuchtigkeit);
            double summeLuftfeuchtigkeit = 0;
            int anzahl = liste.Count;

            foreach (var daten in liste)
            {
                summeLuftfeuchtigkeit += daten.Luftfeuchtigkeit;
            }
            double avgH = summeLuftfeuchtigkeit / anzahl;
        }
        public double BerechneMinimumTemp(List<Wetter> liste)
        {
            //einfacher: var minTemp = liste.Min(x => x.Temperatur);
            double minTemp = liste[0].Temperatur;

            foreach (var daten in liste)
            {
                if (daten.Temperatur < minTemp)
                {
                    minTemp = daten.Temperatur;
                }
            }
            return minTemp;

        }
        public double BerechneMinimumLuft(List<Wetter> liste)
        {
            //einfacher: var minLuft = liste.Min(x => x.Luftfeuchtigkeit);
            double minLuft = liste[0].Luftfeuchtigkeit;

            foreach (var daten in liste)
            {
                if (daten.Luftfeuchtigkeit < minLuft)
                {
                    minLuft = daten.Luftfeuchtigkeit;
                }
            }
            return minLuft;

        }
        public int WerteGruppieren1(List<Wetter> liste)
        {
            int gruppe0bis10 = 0;
            foreach (var daten in liste)
            {
                if (daten.Temperatur < 10 && daten.Temperatur > 0)
                {
                    gruppe0bis10++;
                }
            }
            return gruppe0bis10;

        }
        public int WerteGruppieren2(List<Wetter> liste)
        {
            int gruppe10bis20 = 0;
            foreach (var daten in liste)
            {
                if (daten.Temperatur < 20 && daten.Temperatur > 10)
                {
                    gruppe10bis20++;
                }
            }
            return gruppe10bis20;

        }
        public int WerteGruppieren3(List<Wetter> liste)
        {
            int gruppe20bis30 = 0;
            foreach (var daten in liste)
            {
                if (daten.Temperatur < 30 && daten.Temperatur > 20)
                {
                    gruppe20bis30++;
                }
            }
            return gruppe20bis30;
        }
        public int LuftHoeher79(List<Wetter> liste)
        {
            int anzahl = 0;
            foreach (var daten in liste)
            {
                if (daten.Luftfeuchtigkeit > 79)
                {
                    anzahl++;
                }
            }
            return anzahl;
        }
    }
}
