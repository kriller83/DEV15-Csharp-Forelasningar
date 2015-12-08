using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning4
{
    class MadMath
    {
        //internal static double Add(double tal)
        //{
        //    return tal;
        //}
        //internal static double Add(double a, double b, double c)
        //{
        //    return a + b + c;
        //}
        internal static double Add(params double[] array)   //Ett sätt att stoppa in många tal på (array). Params hanterar det som en array.
        {
            var sum = 0.0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
   }
}
