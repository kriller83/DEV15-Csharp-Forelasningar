using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13._2_CastingThings
{
    class Point
    {
        public float Temp { get;  set; }

        public X(float temp)
        {
            Temp = temp;
        }

        public Y(float temp)
        {
            Temp = temp;
        }
        public static explicit operator _3DPoint(Point point)   
        {
            return new _3DPoint();  
        }
    }
}
