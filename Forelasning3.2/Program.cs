using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMaths;

namespace Forelasning3._2
{
    class Program 
    {
        static void Main(string[] args)
        {
            MathClass mathClass = new MathClass();
            mathClass.PrintValues(new double[] { 5.4, 52.2, 256.4});
            System.Threading.Thread.Sleep(6000);
        }
    }
}
