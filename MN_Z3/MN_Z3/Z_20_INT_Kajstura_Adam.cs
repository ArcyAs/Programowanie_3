using System;

namespace MN_Z3
{
    internal class Program
    {
        private static void WypelnienieMacierzy(double[][] macierzRozszerzona, double[][] macierz, int n)
        {
            for (var i = 0; i < n; i++)
            {
                macierzRozszerzona[i] = new double[n + 1];

                for (var j = 0; j < n + 1; j++)
                    switch (j)
                    {
                        case 0:
                        {
                            macierzRozszerzona[i][j] = 1;
                            break;
                        }

                        case 5:
                        {
                            macierzRozszerzona[i][j] = macierz[1][i];
                            break;
                        }
                        default:
                        {
                            macierzRozszerzona[i][j] = Math.Pow(macierz[0][i], j);
                            break;
                        }
                    }
            }
        }

        private static void MacierzRozwiazana(double[][] a, int n)
        {
            for (var k = 0; k < n; k++)
            {
                var max = a[k][k];
                var r = k;

                for (var i = k; i < n; i++)
                    if (Math.Abs(a[i][k]) > Math.Abs(max))
                    {
                        max = a[i][k];
                        r = i;
                    }

                if (max == 0)
                {
                    Console.WriteLine("Macierz ukladu osobliw");
                    return;
                }

                for (var j = k; j < n + 1; j++)
                {
                    var tmp = a[k][j];
                    a[k][j] = a[r][j];
                    a[r][j] = tmp;

                    a[k][j] /= max;
                }

                for (var i = 0; i < n; i++)
                {
                    if (i == k)
                        continue;

                    var p = a[i][k];

                    for (var j = k; j < n + 1; j++)
                        a[i][j] = a[i][j] - p * a[k][j];
                }
            }
        }

        private static void Wyswietl(double[][] a, int n)
        {
            for (var i = n - 1; i >= 0; i--)
            {
                if (i == 1)
                {
                    Console.Write(a[i][n] + " x");
                }
                else if (i == 0)
                {
                    Console.Write(a[i][n]);
                    break;
                }
                else
                {
                    Console.Write(a[i][n] + " x^" + i);
                }

                Console.WriteLine(" + ");
            }
        }

        private static void Main(string[] args)
        {
            var n = 5;
            double[][] macierz =
            {
                new[] {1.5, 2, 2.5, 3.5, 3.8, 4.1},
                new[] {2, 5, -1, 0.5, 3, 7}
            };

            var Rozszerzona_macierz = new double[n][];

            WypelnienieMacierzy(Rozszerzona_macierz, macierz, n);
            MacierzRozwiazana(Rozszerzona_macierz, n);
            Wyswietl(Rozszerzona_macierz, n);
        }
    }
}