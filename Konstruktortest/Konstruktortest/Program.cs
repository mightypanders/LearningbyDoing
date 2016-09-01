using System;

namespace Konstruktortest
{
    class Program
    {
        static void Main(string[] args)
        {
            double outwert;
            Console.Write("Kreis Radius eingeben: ");
            Double.TryParse(Console.ReadLine(), out outwert);
            c_Kreis kreis = new c_Kreis(outwert);
            kreis.printMe();
            Console.ReadLine();
        }
    }

    class c_Kreis
    {
        private double Radius = 0.0;

        public c_Kreis(double Radius)
        {
            this.Radius = Radius;
        }

        public double getUmfang()
        {
            return 2 + this.Radius * Math.PI;
        }

        public double getFlaeche()
        {
            return Math.PI * (this.Radius*this.Radius);
        }
        public void setRadius(double Radius)
        {
            if(Radius>0.0)
                this.Radius = Radius;
        }
        public double getRadius()
        {
            return this.Radius;
        }

        public void printMe()
        {
            Console.WriteLine("Radius: "+this.getRadius());
            Console.WriteLine("Umfang: " + this.getUmfang());
            Console.WriteLine("Fläche: "+this.getFlaeche());
            
        }
    }
}
