using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Zaliczenie
//Grupa A

{
    class Program
    {
        public static void Pierwsze(int x)
        {
            double y = (2 * (x ^ 3)) - (8 * (x ^ 2)) - (3 * x) + 10;
            Console.WriteLine(y);
        }

        public static void  Drugie(int ilosc)
        {
            
            string[] x = new string[3];
            double[] xcon = new double[3];
            double []sumamies=new double [ilosc];
            double[] tabelaSum = new double[ilosc];
            double[] suma = new double[ilosc];
            for (int i = 1; i < ilosc +2; i++)
            {
                Console.WriteLine("Podaj pierwsza kwote:");
                x[0] = Console.ReadLine();
                Console.WriteLine("Podaj druga kwote:");
                x[1] = Console.ReadLine();
                Console.WriteLine("Podaj trzecia kwote:");
                x[2] = Console.ReadLine();
                Console.WriteLine("Podaj czwarta kwote:");
                x[3] = Console.ReadLine();
                Console.WriteLine("Koniec dnia");
                
                xcon[0] =Convert.ToDouble(x[0]); 
                xcon[1] =Convert.ToDouble(x[1]);
                xcon[2] =Convert.ToDouble(x[2]);
                xcon[3] =Convert.ToDouble(x[3]);
                
                suma[i] = xcon[0]+xcon[1]+xcon[2]+xcon[3];
            }

            for (int i = 1; i < ilosc+2; i++)
            {
                sumamies[i] = sumamies[i - 1] + suma[i];
            }
            
        }

        /*public static void Trzecie()
        {
             double [][1] cos = new double [2][1]
        }
        */
        static void Main(string[] args)
        {
            Pierwsze(20);
            Drugie(2);
            //Trzecie();

        }
    }
}