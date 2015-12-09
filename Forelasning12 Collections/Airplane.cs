using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning12_Collections
{
    class Airplane : IComparable  //Ska jämföra ett flygplan med ett annat flygplan (längst ner)
    {
        public int Seats { get; private set; }

        public int Pilots { get; internal set; }  

        public Airplane(int seats, int pilots)
        {
            Seats = seats;
            Pilots = pilots;
        }

        public override string ToString() => $"Seats: {Seats} Pilots: {Pilots}";
        public int CompareTo(object obj)
        {
            Airplane testPlane = (Airplane) obj;
            //returnera -1,0 eller 1
            return testPlane.Seats.CompareTo(this.Seats);  //sorterar antalet säten
            /*return testPlane.Pilots.CompareTo(this.Pilots);*/  //sorterar piloterna
        }

    }
}
