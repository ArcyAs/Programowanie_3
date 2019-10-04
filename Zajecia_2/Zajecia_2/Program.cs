using System;
using System.Collections.Generic;

namespace Zajecia_2
{
    class Program
    {
        static int[] licznik = {0, 0, 0};
        static int cel = 10;
        static void Etykieta(int index)
        {
            Console.WriteLine("Etykieta"+licznik[index-1]);
            licznik[index - 1]++;
        }

        static int suma()
        {
            int suma = 0;
            for (int i = 0; i < licznik.Length; i++)
            {
                suma += licznik[i];
            }

            return suma;
        }
        
        static void Main(string[] args)
        {
           /*
            1.
            int liczba;
            Console.WriteLine("Wpisz liczbe:");
            string tekst = Console.ReadLine();
            liczba = Convert.ToInt32(tekst);
            
            if (liczba % 2 == 0)
            {
                Console.Write("Parzysta");
            }
            else
            {
                Console.WriteLine("Nieparzysta");
            }

            Console.WriteLine((liczba % 2 == 0) ? "parzysta" : "nieparzysta");
            */
            /*
            2.
            int odleglosc = -1, suma = 0, licznik =0;
           float srednia;
           
           while (odleglosc != 0)
           {
               string odpowiedz = Console.ReadLine();
               odleglosc = Convert.ToInt32(odpowiedz);
               suma += odleglosc;
               licznik++;
           }

           srednia = (float)suma / (licznik - 1);
           Console.WriteLine("Srednia odleglosc: " + srednia);
           */
           string escape = "exit";
            int licznik = 1;
            while (licznik != cel)
            {
                string tekst = Console.ReadLine();
                switch (tekst)
                {
                   case "1":
                       Etykieta(1);
                       break;
                   case "2":
                       Etykieta(2);
                       break;
                   case "3":
                       Etykieta(3);
                       break;
                   default:
                       break;
                }
                Etykieta(licznik);
            }

            Console.WriteLine("Do widzenia");
        }
    }
}