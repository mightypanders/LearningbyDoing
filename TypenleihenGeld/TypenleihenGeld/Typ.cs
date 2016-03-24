using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypenleihenGeld
{
    class Typ
    {
        public string Name;
        public float Geld;

        public float GeldVerleihen(float Betrag)
        {
            if (Betrag <= Geld && Betrag > 0)
            {
                Geld -= Betrag;
                return Betrag;

            }
            else
            {
                MessageBox.Show("Ich habe nicht genug Geld um dir " + Betrag + "€ zu geben, sagt " + Name);


                return 0;

            }


        }

        //das ist ein zweiter Test Kommentar
        //das ist Testkommentar 2.5

        //das ist ein dritter Test Kommentar


        public float GeldEmpfangen(float Betrag)
        {
            if (Betrag > 0)
            {
                Geld += Betrag;
                return Betrag;
            }
            else
            {
                MessageBox.Show(Betrag + " ist kein Betrag den ich akzeptieren kann, sagt " + Name);
                return 0;
            }
        }
    }
}
