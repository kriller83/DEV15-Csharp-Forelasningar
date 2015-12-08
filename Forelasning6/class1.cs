using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6
{
    class Class1
    {
        //Kaitel 6 i boken!!
        //Egenskaper för class 1:
        //    -Datamedlemmar, field fält
        //    -Konstanter
        // Vi kan göra dessa: public, private, static, const... 
        public static int reachableNumber;    //Static = finns bara en variant av den. Om vi vill ha något som kan nås överallt så gör vi det static. 
        private static int notReachableNumber;
        public const double PI = 3.121592654; //const är implicit static (implicit = får det på köpet)
        public static void SetNumber(int number)  //måste vara static, namnkonflikt pga kan inte ha flera notReachableNumbers.
        {
            notReachableNumber = number;
        }

        /*
        //Funktionella medlemmar:
        - Metoder
        - Properties
        - Constructor
        -------------------
        -Destructor
        -Operators
        -Indexer
        -Event
        */


    }
}
