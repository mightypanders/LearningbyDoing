using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisAlsForm
{
    class Kugel : Kreis
    {
        private double oberflache;
        private double volumen;

        public Kugel(double Radius) : base(Radius)
        {
            
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

        public void berechneOberflaeche()
        {
            this.Oberflache = 4 * base.getFlaeche();
        }

        public void berechneVolumen()
        {
            this.Volumen = (4 / 3) * base.getFlaeche() * base.getRadius();
        }


    }
}
