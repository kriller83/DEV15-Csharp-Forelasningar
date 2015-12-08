using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    class Program
    {
        static void Main(string[] args)
        {

            TractorsMethod();
            VaMethod();
            RunstenMethod();
            BulbMethod();

            Hat brownHat = new Hat();
            Console.WriteLine(brownHat);

            Console.ReadLine();

        }

        private static void BulbMethod()
        {
            Bulb philips = new Bulb(0, 50, 60);
            Console.WriteLine(philips);
        }

        private static void RunstenMethod()
        {
            Runsten myRunsten = new Runsten();
            var myRunsten2 = new Runsten(name: "Tore"); //named parameter. Fördel då det ej kan bli fel om någon ändrar i koden.
            var myRunsten3 = new Runsten("Zeke", 450);
            var myRunsten4 = new Runsten("Magnus", 760, 890);
            Console.WriteLine(myRunsten);
            Console.WriteLine(myRunsten2);
            Console.WriteLine(myRunsten3);
            Console.WriteLine(myRunsten4);
        }

        private static void VaMethod()
        {
            //3 instanser av Va som skrivs ut.
            Va vart = new Va();
            var vart2 = new Va("Hej?");
            var vart3 = new Va("Hejsan2?", 9.3);
            Console.WriteLine(vart);
            Console.WriteLine(vart2);
            Console.WriteLine(vart3);
        }

        private static void TractorsMethod()
        {
            //Alla new tractor känner av om det finns en int i konstruktorn, och kopplar rätt.
            Tractor tractor = new Tractor();  //Kan skriva var tractor..
            var tractor2 = new Tractor(6);   //Kopplas til konstruktorn
            var tractor3 = new Tractor(17, 1234567);
            Console.WriteLine(tractor);
            Console.WriteLine(tractor2);
            Console.WriteLine(tractor3);
        }
    }
}
