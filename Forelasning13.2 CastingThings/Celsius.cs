using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13._2_CastingThings
{
    class Celsius
    {
        public float Temp { get; private set; }

        public Celsius(float temp)
        {
            Temp = temp;
        }

        //Vi ska skapa en explicit typkonvertering som returnerar en Farenheit
        //  **Vi översätter en celsius till en farenheit**

        public static /*explicit*/ implicit operator Farenheit(Celsius celsius)   //Vi får in(skickar in) en celsius.  
        {
            return new Farenheit((9.0f/5.0f)* celsius.Temp + 32);     //Returnerar en ny Farenheit (och får tillbaka en farenheit)
        }
    
    }
}


//Om man kan tappa något skall det vara explicit.... annars implicit. 
//