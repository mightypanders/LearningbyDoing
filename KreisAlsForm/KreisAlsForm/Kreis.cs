using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisAlsForm
{
    class Kreis
    {
        private double Radius = 0.0;

        public Kreis(double radius)
        {
            this.Radius = radius;
        }

        public double getFlaeche()
        {
            return Math.PI * (this.Radius*this.Radius);
        }

        public double getUmfang()
        {
            return 2 * Math.PI * this.Radius;
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
