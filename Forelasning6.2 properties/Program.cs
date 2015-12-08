using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game zelda = new Game();
            zelda.Lives = 4; //Tilldelar property ett värde
            Console.WriteLine(zelda.Lives); //hämtar värde

            BiCycle cresent = new BiCycle();
            cresent.Brand = "Cresent";
            cresent.Gears = 1;

            //Object initializer:
            //anger vad de olika properieserna är i construktoranropet
            BiCycle rex = new BiCycle() { Brand="rex", Gears=7 };
            //Do this:
            //bord med stolar och färg 
            //använd getters och setters
            //ersätt med properties
            //använd object initializer
            //använd instansiering med konstruktoranrop
        }
    }
}
