using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_8_basklass_subklass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Wheels = 6, HorsePowers = 55, Passengers = 4 };

            BiCycle bike = new BiCycle()
            {
                Wheels = 2,
                Spokes = 120,
                Passengers = 1
            };
            Console.WriteLine(bike);
            Vehicle vehicle = new Vehicle() { Passengers = 9, Wheels = 4 };
            vehicle.PrintVehicle();  //Anropar metoden
            Console.ReadLine();
        }
    }
}
