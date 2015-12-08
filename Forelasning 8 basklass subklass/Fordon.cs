using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_8_basklass_subklass
{
    class Fordon 
    {
        public int Hjul { get; set; }
        public int Passagerare { get; set; }
    }
    /*Finns det 2 klasser med samma attribut skapa då en baskklass
    och lägg dem i den. Det som skiljer dem åt läggs i separerade underklasser/subklasser*/
    
     //class Cykel : Fordon  //ärver från fordon
    //{
    //    //public int Hjul { get; set; }
    //    //public int Passagerare { get; set; }
    //    public int Ekrar { get; set; }
    //}

    //class Bil : Fordon  //Ärver från fordon
    //{
    //    //public int Hjul { get; set; }
    //    //public int Passagerare { get; set; }
    //    public int Hästkrafter { get; set; }
    //}
}
