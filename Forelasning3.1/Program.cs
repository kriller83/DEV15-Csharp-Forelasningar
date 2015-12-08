using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning3._2;

namespace Forelasning3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            kalkylator kalkylator = new kalkylator();
            kalkylator.PrintMinMaxAverage(new int[] { 1, 2, 3, 4 }); //heapen
            System.Threading.Thread.Sleep(3000);
        }
    }
}
