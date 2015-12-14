using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13._2_CastingThings
{
    class _3DPoint
    {
        public float Temp { get; set; }

        public X(float temp)
        {
            Temp = temp;
        }
        public Y(float temp)
        {
            Temp = temp;
        }
        public Z(float temp)
        {
            Temp = temp;
        }
        public static explicit operator Point(_3DPoint point2)   
        {
            return new Point();  
        }
    }
}
