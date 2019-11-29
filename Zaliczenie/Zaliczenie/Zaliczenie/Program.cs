using System;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Zaliczenie
//Grupa A

{
    class Program
    {
        public static void Pierwsze()
        {
            Console.WriteLine("Podaj zmienna x:");
            string g = Console.ReadLine();
            double x = Convert.ToDouble(g);
            double y = (2 * (Math.Pow(x, 3))) - (8 * (Math.Pow(x,2))) - (3 * x) + 10;
            Console.WriteLine(y);
        }

        public static void  Drugie()
        {
            Console.WriteLine("Podaj rok: ");
            int rok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj numer miesiaca: ");
            int miesiac = Convert.ToInt32(Console.ReadLine());
            int ilosc = DateTime.DaysInMonth(rok, miesiac);
            double [] zarobki = new double[ilosc-1];
            for (int i = 0; i < ilosc-1; i++)
            {
                Random random = new Random();
                int r = random.Next(300, 4000);
                double wynik = r ;
                zarobki[i] = wynik;
            }
            double[] suma = new double[ilosc];
            for (int i = 0; i < ilosc-1; i++)
            {
                if (i == 0)
                {
                    suma[i] = zarobki[i];
                }
                else
                {
                    suma[i] = suma[i - 1] + zarobki[i];
                }
                
            }
            Array.ForEach(suma, Console.WriteLine);
        }

        public static void Trzecie()
        {
            int[][] poszarpana = new int [3][]
            {
                new int[] {2, 6, 8, 7},
                new int[] {3, 4, 7},
                new int[] {2, 1, 13,8,9},
            };
            int [,] prostokatna = new int [3,8];
            for (int i = 0; i <poszarpana.GetLength(0); i++)
            {
                for (int j = 0; j < poszarpana.GetLength(1); j++)
                {
                    prostokatna[i, j] = poszarpana[i][j];
                    Console.WriteLine(prostokatna[i,j]);
                }
            }

        }
        
        static void Main(string[] args)
        {
            //Pierwsze();
            //Drugie();
            Trzecie();

        }
    }
}