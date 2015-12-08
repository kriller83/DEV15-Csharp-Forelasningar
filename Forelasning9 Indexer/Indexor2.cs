using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning9_Indexer
{
    class Indexor2 //Hade varit biblioteket
    {
        //string motsvarar books i ett bibliotek
        string[] values = new string[10]; //Backing store (field)
        //skapar vår indexor.
        public string this[int index]  //this syftar till instansen
        {
            get
            {
                if (index >= 0 && index < values.Length)   //Kontroll på at man hämtar värden inom arrayns gränser
                    return values[index];
                else
                throw new Exception("Out of boundary");

                }
            set
            {
                //Kontrollerar att vi är inom gränser(range) innan vi sätter ett värde.
                if (index >= 0 && index < values.Length)
                    values[index] = value;
                throw new Exception("Out of boundary");
            }
        }       
    }
}
