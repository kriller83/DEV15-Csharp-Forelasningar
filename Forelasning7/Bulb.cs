using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    public class Bulb
    {
        //Skriv propfull och tabba x2
        //Lägg alla fält överst -alltid! 
        private int h;
        private byte s;
        private byte l;
        public int H  //Property som arbetar mot backingfield
        {
            get { return h; }
            set { h = value % 360; }
        }
        public byte S
        {
            get { return s; }
            set
            {
                if (value >= 0 && value >= 0 && value <= 100)
                    s = value;
            }
        }
        public byte L
    {

        get { return l; }
        set
        {
            if (value >= 0 && value <= 100)
                l = value;
        }
    }

        //ctor + 2 x tabb = snippet för konstruktor
        public Bulb(int h, byte s = 50, byte l = 50)
        {
            H = h;
            S = s;
            L = l;
        }
        //Eventuella metoder

        //ToString skall alltid vara längst ner

        public override string ToString() => $"H: {H} S: {S} L: {L}";
    }
}
