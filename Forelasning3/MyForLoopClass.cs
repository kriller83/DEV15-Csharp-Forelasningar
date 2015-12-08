using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning3
{
    class MyForLoopClass
    {
        //åtkomstdirektiv returvärde Identifieraren
        internal void OneToHundred()
        {
            //for(startvärde;villkor;förändring){saker som sker i loopen...}
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
        internal double GetAverage(int[] arrayToCalculateOn)
        {
            double sum = 0;
            for (int i = 0; i < arrayToCalculateOn.Length; i++)
            {
                sum += arrayToCalculateOn[i];
            }

            //Ska dela hela summan av alla tal med hur många tal det finns
            //delar med detta: arrayToCalculateOn.Length
            double result = sum / arrayToCalculateOn.Length;
            return result;
        }
    }
}
