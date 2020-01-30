namespace Zjazd9
{
    internal class Reklama
    {
        public GrupaWiekowa grupawiekowa;
        public Zainteresowania zainteresowania;

        public Reklama(string tekst, GrupaWiekowa grupa, Zainteresowania zainteresowania)
        {
            grupawiekowa = grupa;
            tekst = Tekst;
            this.zainteresowania = zainteresowania;
        }

        public string Tekst { get; set; }
    }
}