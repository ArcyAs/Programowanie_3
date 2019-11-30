using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace Zajecia_V
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;
        public int Id;

        public Osoba(string imie, string nazwisko, int id)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Id = id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = Enumerable.Range(150, 100).ToList(); 
            // lista.ForEach(x => Console.WriteLine(x));
            #region czesc A
            /*
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            IEnumerable<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0);
            foreach (var item in podzielnePrzez3)
            {
                Console.WriteLine(item);
            }

            int suma = podzielnePrzez3.Sum();
            Console.WriteLine(suma);
            double srednia = podzielnePrzez3.Average();
            Console.WriteLine(srednia);
            */
            #endregion
            #region czesc B
            /*
            List<Osoba> osoby =
                lista.Select(x => new Osoba()
                {
                    Imie = x.ToString(),
                    Nazwisko = "AAA",
                    Id = x
                }).ToList();//.ForEach(x => 
               //Console.WriteLine($"{x.Id}; {x.Imie} {x.Nazwisko}"));
               osoby[45].Nazwisko = "BBB";
               osoby.Select(x => x.Nazwisko)
                   .Distinct().ToList().ForEach(Console.WriteLine);
               Osoba osobaB = osoby.Where(x => x.Nazwisko.StartsWith("B")).FirstOrDefault();
               Console.WriteLine($"{osobaB.Id}|{osobaB.Imie}|{osobaB.Nazwisko}");
               int iloscElementowNaStronie = 10;
               int nrStrony = 2;
               List<Osoba> strona = osoby.Skip(iloscElementowNaStronie * (nrStrony - 1)).Take(iloscElementowNaStronie)
                   .ToList();
               foreach (var item in strona)
               {
                   Console.WriteLine($"{osobaB.Id}|{osobaB.Imie}|{osobaB.Nazwisko}");
               }
               */
            #endregion

            var GeneratorFirstName 
                = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var GeneratorFirstLast 
                = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            List<Osoba> osoby = lista.Select(
                x => new Osoba(
                    GeneratorFirstLast.Generate(),
                    GeneratorFirstName.Generate(),
                    x)).ToList();
            foreach (var item in osoby)
            {
                Console.WriteLine($"{item.Id}|{item.Imie}|{item.Nazwisko}");
            }
            
        }
        
    }
} 



//.Select(x => (double)x)