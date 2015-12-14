using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13._2_CastingThings
{
    class Farenheit
    {
        public float Temp { get; set; }

        public Farenheit(float temp)
        {
            Temp = temp;
        }

        //Explicit innebär förlust av data(ofast en property som inte finns i retur-klassen)
        //Implicit brukar innebära att returklassen har en delmängd från ursprungliga

        public static /*explicit*/ implicit operator Celsius(Farenheit farenheit)   //Skickar in en farenheit
        {
            return new Celsius((5.0f/9.0f) * farenheit.Temp - 32);  //Får en celsius
        }
    }
}
