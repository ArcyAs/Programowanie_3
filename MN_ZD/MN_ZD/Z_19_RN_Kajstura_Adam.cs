using System;

namespace MN_ZD
{
    internal class Obliczanie
    {
        public double f(double x)
        {
            return x - (3 * x + Math.Sin(x) - Math.Exp(x)) / fp(x);
        }

        public double fp(double x)
        {
            return 3 + Math.Cos(x) - Math.Exp(x);
        }

        public double Wczytaj(string nazwa)
        {
            Console.WriteLine("Podaj wartość {0}:", nazwa);
            var zmienna = Convert.ToDouble(Console.ReadLine());
            return zmienna;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var f = new Obliczanie();
            double x0, x1, eps;
            var licznik = 0;

            x0 = f.Wczytaj("x0");
            x1 = f.Wczytaj("x1");
            eps = f.Wczytaj("eps");
            do
            {
                x0 = x1;
                x1 = f.f(x0);
                licznik++;
            } while (Math.Abs(x1 - x0) >= eps);

            Console.WriteLine("Wynik: x = {0}, przy dokładności - {1}",
                x1, eps);
            Console.WriteLine(" ilość iteracji : {0}", licznik);
        }
    }
}