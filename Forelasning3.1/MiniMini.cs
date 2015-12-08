using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning3._1
{
    public class MiniMini
    {
        public int GetMinFromArray(int[] theArray)   //skickar in en array som innehåller många tal
        {
            int min = theArray[0];
            for (int i = 0; i < theArray.Length; i++)  //Ska köra arrayen så lång de är
            {
                if (theArray[i] < min)
                    min = theArray[i];
            }
            return min;    //Returnerar till metoden console.writeline
        }
    }
}
