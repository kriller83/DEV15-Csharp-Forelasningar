using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13_Struct
{

    /*
    - en struct är en egendefinierad värdetyp
    - har inga referenser till heapen
    - är implicit sealed
    - är public per default
    - skrivs som vi skriver en klass men har nyckelordet struct
    - alla de primitiva typerna är structar:
    ex. int, long, double, float, char, bool, DateTime
    - Ungefär 3 ggr snabbare än en class om 5 fält finns  
    (Vi undviker att använda heapen)
    - kan inte vara null, pga kan inte referea till heapen
      

   - Kolla upp vad som hamnar i stacken respektive heapen..!! 
    */

    public struct Koordinat
    {
        //Accessbara utfrån. Stora bokstäver - inget privat fält. 
        public int X;
        public int Y;
        public string Z;
      //public int Z = 9;  //Does not compute. Kan inte tilldela en struct ett värde. Får ej göra det. Tappar hela poängen med en struct. Vi får ej sätta värde på fält i en struct. 

        //public Koordinat 
        //{
        //    //Går ej att skapa en constructor i en struct
        //}


       
        public override string ToString()
        {
            return $"X: {X}, Y:{Y} Z:{Z}";
        }
    }

    //struct StructXYZ : koordinat
    //{
    //    //Kan och får inte ärva från en struct. (implicit sealed)
    //}

}
