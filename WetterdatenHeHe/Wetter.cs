using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterdatenHeHe
{
    public class Wetter
    {
        public DateTime Datum {  get; set; }
        public double Temperatur { get; set; }
        public double Luftfeuchtigkeit {  get; set; }

        public Wetter(DateTime datum,double temperatur, double luftfeuchtigkeit) 
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
