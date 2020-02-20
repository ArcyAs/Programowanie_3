using System;

namespace Zjazd_4
{
    class Program
    {
        private static int[] Kopiuj(int[] tablica)
        {
            int[] kopia = new int[tablica.Length];
            for (int i = 0; i < tablica.Length; i++) kopia[i] = tablica[i];
            return kopia;
        }
        private static void Main(string[] args)
        {
            int[] pierwsza = {6, 9, 12};
            int[] druga = Kopiuj(pierwsza);
            for (int i = 0; i < pierwsza.Length; i++) 
                Console.WriteLine(druga[i] + ",");
            int[] x = {4, 8, 12, 16, 20, 24};
            int[] y = new int [x.Length];
            for (int i = 0; i < x.Length; i++) 
                y[i] = x[i];
            x[2] = 100;
            for (int i = 0; i < x.Length; i++) 
                Console.WriteLine(x[i] + ",");
        }
    }
}