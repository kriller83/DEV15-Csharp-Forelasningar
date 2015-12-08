using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning3
{
    class MyForLoop
    {
        public int GetMax(int[] calculationArray)
        {
            //[0], [1], [2] 
            // 1, 2, 3
            int highestNumber = calculationArray[0];
            for (int i = 0; i < calculationArray.Length; i++)
            {
                if (calculationArray[i] > highestNumber)
                    highestNumber = calculationArray[i];
            }

            return highestNumber;
        }
    }
}