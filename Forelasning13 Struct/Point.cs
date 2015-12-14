using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13_Struct
{
    struct Point
    {
        public int X;
        public int Y;


        /*Om vi gör en egen constructor måste alla fält sättas.
        - Man får inte göra en tom konstruktor
        - Om man gör en överlagrad konstruktor måste man sätta ett värde på alla fält.         
            */

        public Point(int x)
        {
            X = x;
            Y = 7;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int GetXy()
        {
            return X + Y;
        }
    }
}
