using System;
using Zjazd8;

namespace Zjazd_nr_8
{
    internal class Program
    {
        private static bool printerOk = true;

        private static void Main(string[] args)
        {
            var drukarka = new Printer(20);

            drukarka.Out_of_paper += Out_of_Paper2;
            drukarka.Out_of_Toner += Drukarka_Out_of_Toner;

            for (var i = 1; i < 30; i++)
            {
                drukarka.Print(i);
                if (!printerOk) return;
            }
        }

        private static void Drukarka_Out_of_Toner(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine("Brak Tuszu " + args.Color);
            printerOk = false;
        }

        private static void Out_of_Paper2(object sender, EventArgs args)
        {
            Console.WriteLine("Brak papieru !!!");
            printerOk = false;
        }
    }
}