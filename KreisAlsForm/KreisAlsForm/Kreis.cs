using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisAlsForm
{
    class Kreis : c_Geo2DObject
    {
        private double Radius = 0.0;
        private double Flache = 0.0;
        private double Umfang = 0.0;

        public Kreis(double radius)
        {
            this.Radius = radius;
        }

        override public void berechneFlaeche()
        {
            this.Flache = Math.PI * (this.Radius * this.Radius);
        }

        override public void berechneUmfang()
        {
            this.Umfang = 2 * Math.PI * this.Radius;
        }

        override public void berechneAlles()
        {
            this.berechneFlaeche();
            this.berechneUmfang();
        }

        public double getFlaeche()
        {
            return Flache;
        }

        public double getUmfang()
        {
            return Umfang;
        }

        public bool setRadius(double Radius)
        {
            if (Radius > 0.0)
            {
                this.Radius = Radius;
                return true;
            }else
            {
                return false;
            }
            
        }

        public double getRadius()
        {
            return this.Radius;
        }
    }

}
