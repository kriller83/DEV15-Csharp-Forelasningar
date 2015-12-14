using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13_Struct
{
    internal struct Mixture
    {
        public bool MyBool;
        public double MyDouble;
        public Int64 MyInt;

        //public Mixture()
        //{

        //}

        public Mixture(bool myBool, double myDouble, int myInt)
        {
            MyBool = myBool;
            MyDouble = myDouble;
            MyInt = myInt;
        }

        public override string ToString()
        {
            return $"Mybool: {MyBool}, Mydouble: {MyDouble}, MyInt: {MyInt}";
        }
    }
}
