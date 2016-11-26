namespace KreisAlsForm
{
    public interface Geo3DObject
    {
        void berechneOberflaeche();
        void berechneVolumen();
        void berechneAlles();
    }
    public interface Geo2DObject
    {
        void berechneFlaeche();
        void berechneUmfang();
        void berechneAlles();
    }
}
