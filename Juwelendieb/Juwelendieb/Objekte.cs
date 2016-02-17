using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juwelendieb
{
    class Juwelen
    {
        public string Glitzern()
        {
            return "Blink, Blink";
        }
    }
    class Safe
    {
        private Juwelen inhalt = new Juwelen();
        private string SafeKombination = "12345";
        public Juwelen oeffnen(string kombi)
        {
            if (kombi == SafeKombination)
            {
                return inhalt;
            }
            else
            {
                return null;
            }
        }
        public void schlossknacken(Schlosser knacker)
        {
            knacker.Kombinationaufschreiben(SafeKombination);
        }
    }
}
