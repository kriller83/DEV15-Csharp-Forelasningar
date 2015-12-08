using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu.PrintMenu();
            //WhileLoop();       
            //ForEach();        //foreach = för varje. Missar ingenting, tar alla element. 
            //BreakingNews();
            //ForOchForEach();
            //DecimalerFloat();
            Console.WriteLine(MadMath.Add(5.8, 1.3, 2.5, 4.6, 3.7));

            Console.ReadLine();
        }

        private static void DecimalerFloat()
        {
            int tal2 = 5;
            for (float i = 0.0f; i < 2.0f; i += 0.1f)   //gäller det float, eller byte m.m så skriv f eller b efter. Behövs ej på int eller double. 
            {
                Console.WriteLine(i);
            }
        }
        //refaktorera = göra koden mer läsbar
        //System.Int32 tal = 5;    ..går att skriva istället för int. Se sid 39 i boken! 
        // byte = 8st 1or & 0or. short = 16st. int = 32st. long = 64st.

        //const double GRAVITY = 9.82;  //GRAVITY = konstant. Går ej att förändra, den är exakt samma om stora bokstäver. Const skyddar konstanten. 
        //Uppercase = konstanter (sådana som vi aldrig ändrar)

        private static void ForOchForEach()
        {
            int[] ages =
                new int[] { 2, 12, 88, 3, 12, 3, 123, 1 };
            foreach (int item in ages)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("FOR minus 3or:");
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] == 3)
                    continue;
                Console.WriteLine(ages[i]);
            }
        }

        //**METOD**
        //åtkomstdirektivet
        //klassmetod eller ett objekt
        //returtypen
        //identifieraren
        //inparametarar  (dör efter scoopet)
        private static void BreakingNews()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    //break; //Bryter hela loopen
                    return;  //Struntar i allt annat i metoden
                // continue;  //hoppar över en enda loop
                Console.WriteLine(i);
            }
            Console.WriteLine("Nisse");
        }

        private static void WhileLoop()
        {
            int n = 0; //startvärde
            while (n > -4)    //villkor
            {
                Console.WriteLine("Hejhej {0}", n);  //Formatsträng
                n--; //förändring
            }
        }

        private static void ForEach()
        {
            string[] names = new string[]
            {"Göran", "Majja","Lars","Kriss","Myh"};
            foreach (string element in names)
            {
                Console.WriteLine(element);
            }

        }




       
}
}
