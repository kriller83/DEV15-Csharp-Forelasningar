using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Högerklicka på projektet och välj "View class diagram"
namespace Forelasning_8_basklass_subklass
{
    class Vehicle
    {
        //property + tab tab
        public int Wheels { get; set; }
        public int Passengers { get; set; }

        //public int Exempel { get; set; } = 7;  = nytt sätt att skriva på.. 
        public void PrintVehicle()  //en metod. 
            //Mindre bra sätt att skriva ut en instans på..
        {
            //Kräver vi ett Console-projekt
            Console.WriteLine($"Metoden i basklassen Vehicle säger\r\n Wheels: {Wheels}\r\n Passengers: {Passengers}");
            //Object titt; använde vi för att f12 oss till Objekt och se att toString var virtual

        }
        //ToString fungerar i alla projekttyper och är därför att föredra.
        public override string ToString() => $"Metoden i basklassen Vehicle säger\r\n Wheels: {Wheels}\r\n Passengers: {Passengers}";
       //ToString håller reda på alla properties i basklassen
        
        //Virtual = override

        //Går även att skriva såhär:
        //public override string ToString()
        //{
        //    return $"Metoden i basklassen Vehicle säger\r\n Wheels: {Wheels}\r\n Passengers: {Passengers}";
        //}
    }

    class BiCycle : Vehicle
    {
        public int Spokes { get; set; }
        public override string ToString()  //Skriver ut alla specifika cykel properties (spokes), sen anropar den base.ToString
        {
            return string.Format("Spokes: {0} Resten: {1}", Spokes, base.ToString());  //base = anropar basklassens värde (toString) = Wheels och Passengers
        }
    }
    class Car : Vehicle  //Vi får arvet genom att skriva : Vehicle
    {
        public int HorsePowers { get; set; }
    }
}

