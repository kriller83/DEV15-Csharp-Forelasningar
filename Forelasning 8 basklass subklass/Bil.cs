using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En klass skall ALLTID ligga i egen fil. exempelvis Bil.cs och Cykel.cs
namespace Forelasning_8_basklass_subklass
{
    class Bil : Fordon  //Ärver från fordon
    {
        //public int Hjul { get; set; }
        //public int Passagerare { get; set; }
        public int Hästkrafter { get; set; }
    }
}
