using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisAlsForm
{
    class Rechteck
    {
        private double SeiteA = 0.0;
        private double SeiteB = 0.0;

        public Rechteck(double SeiteA, double SeiteB)
        {
            this.SeiteA = SeiteA;
            this.SeiteB = SeiteB;
        }
        public double getFlache()
        {
            return SeiteB * SeiteA;
        }
        public double getUmfang()
        {
            return SeiteA * 2 + SeiteB * 2;
        }
        public void setSeiteA(double SeiteA)
        {
            if (SeiteA>0.0)
            this.SeiteA = SeiteA;
        }
        public double getSeiteA()
        {
            return this.SeiteA;
        }
        public void setSeiteB(double SeiteB)
        {
            if(SeiteB>0.0)
            this.SeiteB = SeiteB;
        }
        public double getSeiteB()
        {
            return this.SeiteB;
        }
    }
}
