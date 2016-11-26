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
        private double mantelflache;

        public Kegel(double Radius, double Hoehe) : base(Radius)
        {
            this.Hoehe = Hoehe;
            berechnMantel();
            
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

        public double Manteflache
        {
            get
            {
                return mantelflache;
            }

            set
            {
                mantelflache = value;
            }
        }

        private void berechnMantel()
        {
            this.Manteflache = Math.PI * this.getRadius() * Math.Sqrt((Math.Pow(this.getRadius(), 2) + Math.Pow(this.Hoehe, 2)));
        }

        public void berechneOberflache()
        {
            berechnMantel();
            Oberflache = base.getFlaeche() + Manteflache;
        }

        public void berechneVolumen()
        {
            this.Volumen = (this.Hoehe / 3) * this.getFlaeche();
        }

        new public void berechneAlles()
        {
            base.berechneAlles();
            berechnMantel();
            berechneOberflache();
            berechneVolumen();
        }
    }
}
