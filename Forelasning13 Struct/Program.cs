using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13_Struct
{

    //Struct - finns ingen referens till heapen.
    //Byggs på i stacken

    class Program
    {
        static void Main(string[] args)
        {
            //StructDemo1();
            //StructDemo2();

            Mixture mix = new Mixture() {MyBool = true, MyDouble = 4.5, MyInt = 7};
            //mix.MyBool = true;
            //mix.MyDouble = 4.5;
            //mix.MyInt = 7;
            Console.WriteLine(mix);


        }


        private static void StructDemo2()
        {
            //Point ett = new Point();
            Point ett;
            ett.X = 4;
            ett.Y = 5;
            ett = new Point(0);  //defaultvärden
            Console.WriteLine("X:{0}, Y:{1}", ett.X, ett.Y);
            Console.WriteLine(ett.GetXy());
            Console.ReadLine();
        }

        private static void StructDemo1()
        {
            Koordinat koordinat /*= new Koordinat()*/;    //behövs egentligen inte skrivas, men går bra ändå.
            koordinat.X = 66;
            koordinat.Y = 88;

            Koordinat origo = new Koordinat() { X = 50, Y = 50 };
            origo.X = 8;
            origo.Z = "9";    //Strängen pekar ut på heapen, men inte structen. 
            origo = new Koordinat(); /*Nollställer structen. 
            Alla fält får defaultvärden för respektive datatyp. Observera att string fick null i sig nu. */
            Console.WriteLine(origo);
        
        }
    }
}


/* 

 Initializer innan ctor..
    
 Skapa en:

 1. Mixture<(struct)>
 2. MyBool: bool
 3. MyDouble: double
 4. MyInt: int64
 -------------------
 5. Mixture()       (Verifiera att det ej går)
 6. Mixture(,,)
 7. ToString(): string
 */