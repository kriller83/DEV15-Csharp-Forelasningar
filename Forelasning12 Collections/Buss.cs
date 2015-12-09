using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning12_Collections
{
    class Buss
    {
        public int Seats { get; set; }  //Bara den här klassen som kan använda (private)

        public int HorsePowers { get;  set; }

        public Buss(int seats, int horsePowers)
        {
            Seats = seats;
            HorsePowers = horsePowers;
        }

        public override string ToString() => $"Seats: {Seats} Horsepowers: {HorsePowers}";

        //{
        //    string.Format("Seat:{0}, HorsePowers{1}", Seats, HorsePowers);

        //  return $"Seats: {Seats} Horsepowers: {HorsePowers}";
        //}
    }
}
