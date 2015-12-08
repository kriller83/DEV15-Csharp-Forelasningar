using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6
{
    class Program
    {
        static int tal = 9;  //static static static
        int talSomÄrInstans = 10;
        static void Main(string[] args)
        {
            tal = 5;

            talSomÄrInstans = 7;  //fungerar ej då den ej är static
            Program program = new Program();  //måste skapa en ny instans för att det skall fungera. 
            program.talSomÄrInstans = 455;


            Class1 class1 = new Class1();
            //class1.reachabNumber;   ..fungerar ej


            Class1.reachableNumber = 7;
            Class1.notReachableNumber = 9;  //har ej tillgång
            Class1.PI = 5;  //Kan skriva ut den men ej ändra då den är konstant. Const är implicit.
        }
    }
}
