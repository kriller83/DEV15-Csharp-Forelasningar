using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning5._5_Var
{
    class Class1
    {
        /*var funkarEjHärUteEftersomDetÄrEnInstans(); */  //funkar ej här
        static void Main(string[] args)
        { 
        var stålis = new SuperManVeryLongNaaaame();
            var heltal = 5;
            var decimaltal = 5.9;
            var stortHeltal = 3456L;
            var litetHeltal = 4.9f;
            var text = "some";
            text = "vilken text som helst, men inte annan datatyp";
            var tal = new int[] { 34, 34, 34, 32, 21, 4, 5, 6, 32 };
            foreach (var datatypenintfrånvektorn in tal)
            {
                Console.WriteLine(datatypenintfrånvektorn);
            }

    }
    }
}
