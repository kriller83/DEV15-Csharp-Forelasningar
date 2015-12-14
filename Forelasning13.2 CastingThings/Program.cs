using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13._2_CastingThings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*long tal = 5;*/    //Castas implicit

            Farenheit farenheit = new Farenheit(100.0f);
            Console.WriteLine($"Farenheit: { farenheit.Temp}");

            //VI har en farenheit och gör omd et till en cecius, och sedan tillbaka till farenheit

            //Implicita typkonverteringar

            //Casta farenheit till celsius
            Celsius celcius = (Celsius) farenheit;    //Typcastar
            Console.WriteLine($"Celcius: {celcius.Temp}");


            //Casta celsius till farenheit
            Farenheit farenheit2 = (Farenheit) celcius;
            Console.WriteLine($"Farenheit: {farenheit2.Temp}");


           Point point = new Point(4,6);
            Console.WriteLine();

           _3DPoint point2 = new _3DPoint();
            Console.WriteLine();


        }
    }
}
