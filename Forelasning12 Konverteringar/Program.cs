using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning11_Konverteringar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konverteringar();

            Cykel c1 = new Cykel();  //OK! 
            MC mc = new Cykel();  //Ej OK. Kan ej känna igen vad som finns under.. 
            MC mc2 = (MC)c1;  //Explicit typkonvertering
            //Kompilatorn upptäcker inte felet förrän under programkörning

            //TEST med as:
            Cykel cykel = (Cykel)new MC();
            MC mcTest = c1 as MC;    //Försöker göra om c1 till en MC.
            if (mcTest != null)   //Kontrollerar att mc är giltig
            {
                //Konverterad
            }

            //Hej på dig! 


            //TEST med is:
            Object obj = new Cykel();
            bool b = obj is Cykel;  //Allways true

            Cykel cykel2 = new Cykel();
            Boolean f = cykel2 is object;

            //Boxing:
            int tal = 5;
            object paket = tal; //Boxing - värdetyp till referenstyp. Ett tal läggs i boxen. 

            //Unboxing:
            int tal23 = (int)paket;  //Unboxing - referenstyp till värdetyp.. Öppnar ett paket och plockar upp ett tal exempelvis. 
 

        }

        private static void Konverteringar()
        {
            long tal = 200;   //long = Int 64. 200 = Int 32    //Implicit typkonvertering. Gör automatisk typkonvertering..
            // int tal2 = 200L;  //Risk för förlust.. 
            int tal2 = (int)200L;  //Explicit typkonvertering (extra!)

            //Litteraler
            System.Int64 longTal = 200L;
            System.Int32 intTal = 200;
            var doubleTal = 4.4;
            /* float flyttal = (float)4.4;*/ //Typkonvertering
            float flyttal = 4.4F; //ej typkonvertering
            int number = (int)doubleTal;  //Typkonverterar. Förlorar decimalen.. En int kan ej ta en double. 
                                          //Alltid när vi gör explicit typkonvertering kan vi FÖRLORA NÅGOT. 
                                          //Om vi gör en implicit typkonvertering är den nya behållaren "större" så vi får plats med allt. 
        }
    }
}
