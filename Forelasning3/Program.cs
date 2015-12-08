using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning3._1;

namespace Forelasning3
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniMini minimini = new MiniMini();  //skapar en mininmin.. skapar ett objekt av klassen
            Console.WriteLine(
                minimini.GetMinFromArray(new int[] { 4, 5, 6, -4 }));
            System.Threading.Thread.Sleep(3000);
        }
    }
}
