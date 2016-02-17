using System;

namespace Juwelendieb
{
    class Dieb : Schlosser
    {
        private Juwelen gestohleneJuwelen = null;

        public override void InhaltZuruckgeben(Juwelen safeinhalt, Besitzer besitzer)
        {
            gestohleneJuwelen = safeinhalt;
            Console.WriteLine("Ich klau die Klunker " + gestohleneJuwelen.Glitzern());
        }
    }

    class Besitzer
    {
        private Juwelen erhaltenerInhalt;
        public void InhaltEntnehmen(Juwelen safeInhalt)
        {
            erhaltenerInhalt = safeInhalt;
            Console.WriteLine("Vielen Dank für meine Steinchen " + safeInhalt.Glitzern());
        }
    }

    class Schlosser
    {

        public void SafeOeffnen(Safe safe, Besitzer besitzer)
        {
            safe.schlossknacken(this);
            Juwelen safeinhalt = safe.oeffnen(notierteKombination);
            InhaltZuruckgeben(safeinhalt, besitzer);
        }
        private string notierteKombination = null;
        public void Kombinationaufschreiben(string kombination)
        {
            notierteKombination = kombination;
        }
        public virtual void InhaltZuruckgeben(Juwelen safeinhalt, Besitzer besitzer)
        {
            besitzer.InhaltEntnehmen(safeinhalt);
        }
    }

}