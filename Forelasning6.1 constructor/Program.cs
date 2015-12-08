using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6._1_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //Finns ingen tom konstruktor tvingar vi användaren att följa signaturen för en annan konstruktor..
            //    //Person lisa = new Person("Karlsson");
            //    //Person stina = new Person(7, "Svensson");

            Rectangle rektangel = new Rectangle();
            Rectangle rektangel2 = new Rectangle(3.2);
            Rectangle rektangel3 = new Rectangle(3.5, 5.7);

            //Named parameters
            Rectangle rektangel4 = new Rectangle(width:44.3, height: 23.2);
            Rectangle rektangel5 = new Rectangle(width: 23.2, height: 44.3);
        }       
    }
}
