using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning12_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista1();
            //Lista2();
            //Lista3Busses();
            //AirplaneList();
            //ArraySyntaxerList();
            //ClearList();
            //SortList();
            //AiplaneList();

            List<int> tal = new List<ovning>


            Console.ReadLine();

        }

        private static void AiplaneList()
        {
            var planes = new List<Airplane>();
            {
                new Airplane(seats: 22, pilots: 2);
                new Airplane(seats: 23, pilots: 3);
                new Airplane(seats: 26, pilots: 5);
                new Airplane(seats: 28, pilots: 5);
                new Airplane(seats: 20, pilots: 6);
                new Airplane(seats: 29, pilots: 7);


            };
            planes.Sort();
            //planes.Reverse();
            foreach (var airplane in planes)
            {
                Console.WriteLine(airplane);
            }
        }

        private static void SortList()
        {
            List<int> tal = new List<int>
                (new int[] { 3, 4, 5, 7, 29, 6, 4, 3, 5, 6 });
            int indexPosition = tal.IndexOf(29); //poistion 4 är första förekomsten av 29
            Console.WriteLine(indexPosition);  //Skriver ut 4
            indexPosition = tal.IndexOf(17);
            //tal.     ..kommer upp en lista på massa olika alternativ.
            Console.WriteLine(indexPosition);
        }

        private static void ClearList()
        {
            List<bool> lista = new List<bool>() { true, false, false, true };  //Object initializer
            lista.Add(true);
            lista.Add(false);
            // lista.Add(null); gå ej..
            lista.Add(true);
            Console.WriteLine(lista.Count);   //Count = Lenght.. Antal element  Skriver ut 7 element
            lista.Clear();  //raderar allt
            Console.WriteLine(lista.Count);  //Skriver ut allt igen
        }

        private static void ArraySyntaxerList()
        {
            var storlekar = new List<int>()
            {4343, 545, 65, 67, 3, 4, 554, 656, 90};
            storlekar.Sort();
            storlekar.Reverse();
            foreach (var s in storlekar)
            {
                Console.WriteLine(s);  //Skriver ut storlekarna högst till lägst
            }

            var storlekar2 = new List<int>()       //Kan skriva så här också.. värde och referens (kopia och storlekar)
            {4343, 545, 65, 67, 3, 4, 554, 656, 90};
            var kopia = storlekar2;
            storlekar2.Sort();
            storlekar2.Reverse();
            foreach (var s in kopia)
            {
                Console.WriteLine(s);  //Skriver ut storlekarna högst till lägst
            }

            for (int i = 0; i < storlekar.Count; i++)
            {
                Console.WriteLine(storlekar[i]);
            }
        }

        private static void AirplaneList()
        {
            var JAS = new Airplane(seats: 5, pilots: 2);
            var JAS39 = new Airplane(seats: 3, pilots: 3);
            JAS.Pilots = 8;
            var planes = new List<Airplane>() { JAS, JAS39 };
        }

        private static void Lista3Busses()
        {
            var busses = new List<Buss>();
            for (int i = 0; i < 20; i++)
            {
                busses.Add(new Buss(seats: 8 + i, horsePowers: 900));
            }
            foreach (var buss in busses)
            {
                Console.WriteLine(buss);
            }
        }

        private static void Lista2()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 50; i++)  //50 personer
            {
                persons.Add(new Person("Name" + i, i % 30));
            }
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }

        private static void Lista1()
        {
            var lisa = new Person("Lisa", 29);
            var raffe = new Person("Rafael", 44);
            List<Person> persons = new List<Person>();    //Nu är det bara person som fungerar..       //List är en kollektionsklass
            persons.Add(lisa);
            persons.Add(raffe);
            foreach (var person in persons)    //Väldigt bra att använda foreach här..
            {
                Console.WriteLine(person.Name);
            }
            //MoveNext = flyttar från lisa til raffe till avslut
            //Current
        }
    }
}


// 1. Skapa en datatyp
// 2. Lägg 2 i en List<T>
// 3. Fråga efter ett minantal
// 4. Skriv ut dem som stämmer