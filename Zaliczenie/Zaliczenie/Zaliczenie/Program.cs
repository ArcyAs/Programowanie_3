using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            int y= new int();
            int[][] poszarpana =
            {
                new int[] {2, 6, 8, 7},
                new int[] {3, 4, 7},
                new int[] {2, 1, 13,8,9},
            };
            int[] ilosc = new int[poszarpana.Length];
            for (int i = 0; i < poszarpana.Length; i++)
            {
                ilosc[i] = poszarpana[i].Length;
                if (y<ilosc[i])
                {
                    y = ilosc[i];
                }
            }
            int[,] prostokatna = new int [poszarpana.Length,y];

            for (int i = 0; i < poszarpana.GetLength(0); i++)
            {
                int x = poszarpana[i].Length;
                    for (int k = 0; k < x; k++)
                    {
                        prostokatna[i, k] = poszarpana[i][k];
                        Console.WriteLine(prostokatna[i,k]);
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