using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisAlsForm
{
    class Kegel : Kreis
    {
        private double hoehe;
        private double oberflache;
        private double volumen;
        private double derkegelhalt;

        public Kegel(double Radius, double Hoehe) : base(Radius)
        {
            this.Hoehe = Hoehe;
            this.Derkegelhalt = Math.PI * this.getRadius() * Math.Sqrt((Math.Pow(this.getRadius(), 2) + Math.Pow(this.Hoehe, 2)));
        }
        public double Hoehe
        {
            get
            {
                return hoehe;
            }

            set
            {
                hoehe = value;
            }
        }

        public double Oberflache
        {
            get
            {
                return oberflache;
            }

            set
            {
                oberflache = value;
            }
        }

        public double Volumen
        {
            get
            {
                return volumen;
            }

            set
            {
                volumen = value;
            }
        }

        public double Derkegelhalt
        {
            get
            {
                return derkegelhalt;
            }

            set
            {
                derkegelhalt = value;
            }
        }

        public void berechneOberflache()
        {
            Oberflache = base.getFlaeche() + Derkegelhalt;
        }
        public void berechneVolumen()
        {
            this.Volumen = (this.Hoehe / 3) * this.getFlaeche();
        }
    }
}
