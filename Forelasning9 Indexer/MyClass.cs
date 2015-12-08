using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning9_Indexer
{
    class MyClass
    {
        int[] ints;  //Array som är ett backingfield
        public int this[int index]  //skriv: "indexer" + tab + tab
        {
            get { return ints[index]; }  //Arrayn innehåller positionen på dessa (ints)
            set { ints[index] = value; }
        }
        public MyClass()  //skapar myclass objekt. Har tillgång via indexorn
        {
            ints = new int[10];
        }
        public int[] GetInts()
        {
            return ints;
        }
    }
}
