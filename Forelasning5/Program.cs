using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning5
{
    class Program
    {
        static void Main(string[] args)
        {
            //här deklareras tre värden
            int ickeMagi = 6;     //måste skapa ett värde
            double enTill = 4;
            string hej = "haha";
            Magiska(ref ickeMagi, ref enTill, ref hej);  //ref pekar tillbaka till variablen ickeMagi. ref kan bara returnera en enda sak.. 
            Console.WriteLine(ickeMagi);
            Console.WriteLine(enTill);
            Console.WriteLine(hej);
            System.Threading.Thread.Sleep(10000);
        }
        static void Magiska(ref int ickeMagi, ref double enTill, ref string hej)   //tal = ickeMagi. En struct lägger sig i stacken. Hade ej funkat i en metod
        {
            ickeMagi = 5;
            enTill = 8;
            hej = "MOhahahaaa!";
        }
        //Vi förändrar det yttre, innefrån, med hjälp av en ref. 
    }
}
