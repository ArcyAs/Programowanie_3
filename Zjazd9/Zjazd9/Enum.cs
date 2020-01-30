using System;

namespace Zjazd9
{
    [Flags]
    public enum GrupaWiekowa
    {
        Brak = 0, //0000
        Dzieci = 1, //0001
        Mlodziez = 2, //0010
        Dorosli = 4, //0100
        Starsi = 8 //1000
    }

    public enum Zainteresowania
    {
        Komputery = 0,
        Sport = 1,
        Gaming = 2
    }
}