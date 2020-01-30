using System;

namespace Z4
{
    internal class Program
    {
        private static int[] Kopiuj(int[] tab)
        {
            var nova = new int[tab.Length];
            for (var i = 0; i < tab.Length; i++) nova[i] = tab[i];

            return nova;
        }

        private static void Main(string[] args)
        {
            int[] tab1 = {1, 2, 3};

            var tab2 = Kopiuj(tab1);


            for (var i = 0; i < tab1.Length; i++) Console.Write(tab2[i] + ",");
            Console.WriteLine();

            int[] x = {1, 2, 3, 4, 5, 6};
            var y = new int [x.Length];

            for (var i = 0; i < x.Length; i++) y[i] = x[i];

            x[2] = 100;

            for (var i = 0; i < x.Length; i++) Console.Write(x[i] + ",");

            Console.ReadLine();
        }
    }
}