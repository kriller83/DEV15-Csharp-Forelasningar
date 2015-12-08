using System;  //gör att vi kan använda namespacet system med t.ex klassen console
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// skriv tre slashar så dyker detta upp... Används när man är mer avancerad
/// </summary>
/// 


//är en inkapsling för projektet. Kallas för assemblyt,projektet eller namespacet. 
namespace Anteckningar  //PascalCase undvik åäö i ditt namespace. Skriv stor bokstav för nytt ord, som i javascript. 
{
    class basiccsharp   //Inkaplsing av en klass
    {
        //Metoden som startar hela programmet: 
        static void Main(string[] args)
        {

            Console.WriteLine("Hur varmt är det idag?");
            int temperature = int.Parse(Console.ReadLine());  //skapar variabel av typen heltal (int) Vi ger den ett värde som ser vad som skrivs in i konsollen
            if (temperature > 100)
            {
                Console.WriteLine("ånga");
            }
            else if (temperature < 0)
            {
                Console.WriteLine("Is");
            }
                else 
            {
                Console.WriteLine("Vatten");
            }


            Console.WriteLine("Hur varmt är det idag?");
            int temperature = int.Parse(Console.ReadLine());  //skapar variabel av typen heltal (int) Vi ger den ett värde som ser vad som skrivs in i konsollen
            if (temperature > 45)
            {
                Console.WriteLine("gott");
            }
            else if (temperature 5 > 15)
            {
                Console.WriteLine("Ice coffee");
            }
            else
            {
                Console.WriteLine("usch");
            }



            //int tal = 4,
            //    tal2 = 5,
            //    summa = tal + tal2;

            int tal = 4;
            int tal2 = 5;
            int summa = tal + tal2;

           /* Console.WriteLine("Hej hej\r\n på dig");*/  //\r\n skapar en ny rad

            Console.WriteLine("Summan av " + tal + "+" + tal2 + "är lika med " + summa);
            Console.WriteLine("summan av { 0} + { 1} är { 2}", tal,tal2,summa);  // = rätt sätt att skriva på!! 

            //Console tillhör tangentbord, skärm input output 
            Console.ReadLine();   /* Tryck på f1 för att se hur metoden kan användas..BRA grejer!! Testa f12*/

            /* Identifierare = sånt vi själva döper
            Döp till vettiga namn.
            Klasser, metoder, variabler m.m.
            Undvik nyckelord

            PascalCase = varje nytt ord blir stor bokstav (används när det är inkapslat, dvs omringad av måsvingar)
            -används till namespace, class, metoder, enum, struktar, interface och properties

            camelCase = börjar med små bokstäver, varje nytt ord med stor bokstav (Används när det inte är inkapslat, dvs inga måsvingar)
            -används till variabler/fält.

            UPPERCASE = bara stora bokstäver (används när ett värde inte förändras)
            - används till konstanter, ex PI

            */
        }
    }
}
