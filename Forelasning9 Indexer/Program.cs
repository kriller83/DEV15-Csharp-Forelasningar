using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning9_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexor2 test = new Indexor2();
            //test[0] = "Plats 1";
            //test[7] = "Plats 7";
            //test[11] = "Epic failure";
            for (int i = 0; i < 10; i++)
            {
                test[i] = i.ToString();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.ReadLine();
        }
    }
}
