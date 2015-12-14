using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13._1_StructOperatorOverlagring
{
    class Program
    {
        static void Main(string[] args)
        {
            Cycle timCycle = new Cycle(3,21);
            Cycle sebbeCycle = new Cycle(1,3);

            sebbeCycle += 2;
            //sebbeCycle = sebbeCycle + 7;  // 

            ////sebbeCycle -= 3;
            //sebbeCycle = sebbeCycle - 7;


            //sebbeCycle = 5 + sebbeCycle;      // Tal + sebbecyckel (int + cycle)

            int tal = 12 + sebbeCycle;
            Console.WriteLine("tal + cycle=" + tal);
   
            //sebbeCycle *= 2;
            //sebbeCycle = sebbeCycle * 4;


            ////sebbeCycle /= 3;
            //sebbeCycle = sebbeCycle/3;
            

            Console.WriteLine(sebbeCycle);
            Console.ReadLine();

        }
    }
}
