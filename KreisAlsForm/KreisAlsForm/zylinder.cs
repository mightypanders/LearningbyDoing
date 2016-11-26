using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisAlsForm
{
    class Zylinder : Kreis, Geo3DObject
    {
        double oberflache;
        double volumen;
        double hoehe;

        public Zylinder(double Radius, double hoehe) : base(Radius)
        {
            this.Hoehe = hoehe;
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

        public void berechneOberflaeche()
        {
            this.Oberflache = 2 * this.getFlaeche() + this.getUmfang() + this.Hoehe;
        }

        public void berechneVolumen()
        {
            this.Volumen = this.getFlaeche() * this.Hoehe;
        }

        new public void berechneAlles()
        {
            base.berechneAlles();
            berechneOberflaeche();
            berechneVolumen();
        }
    }
}
