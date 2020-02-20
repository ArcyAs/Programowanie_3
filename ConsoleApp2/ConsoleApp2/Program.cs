using System;
using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace cos
{
    class Program
    {
        public class Date
        {
            public  DateTime date;
            public  TimeSpan czas;
            public int id;
            public Date(DateTime? date, TimeSpan? czas, int id)
            {
                this.date = (DateTime) date;
                this.czas = (TimeSpan) czas;
                this.id = id;
            }
        }
        

        static void Main(string[] args){
            var GeneratorDate 
                = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime());
            var GeneratorCzas
                = RandomizerFactory.GetRandomizer(new FieldOptionsTimeSpan());
            List<int> lista = Enumerable.Range(1, 50).ToList();
            List<Date> daty = lista.Select(
                x => new Date
                (GeneratorDate.Generate(), GeneratorCzas.Generate(), x)).ToList();
            foreach (var item in daty)
            {
                Console.WriteLine($"{item.id}:{item.date} {item.czas}");
            }
            
            Console.ReadKey();
        }
        
    }
}