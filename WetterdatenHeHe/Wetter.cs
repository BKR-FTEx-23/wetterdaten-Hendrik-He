using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterdatenHeHe
{
    public class Wetter
    {
        public DateTime Datum { get; set; }
        private double temperatur;
        public double Temperatur
        {
            get { return temperatur; }
            set
            {
                if (value < -50 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Temperatur", "Die Temperatur muss zwischen -50°C und +50°C liegen.");
                }
                temperatur = value;
            }
        }
        public double Luftfeuchtigkeit { get; set; }

        public Wetter(DateTime datum, double temperatur, double luftfeuchtigkeit)
        {
            this.Datum = datum;
            this.Temperatur = temperatur;
            this.Luftfeuchtigkeit = luftfeuchtigkeit;
        }

        public override string ToString()
        {
            string datum = Datum.ToString("yyyy-MM-dd HH:mm:ss");
            string temperatur = Temperatur.ToString();
            string luftfeuchtigkeit = Luftfeuchtigkeit.ToString();
            return $"{datum};{temperatur};{luftfeuchtigkeit}";
        }
    }
}
