using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning12_Collections
{
    class ovning
    {
        public int Apelsin { get; set; }
        public int Äpple { get; set; }
        public int Kanin { get; set; }

        public ovning()
        {
            Apelsin = 7;
            Äpple = 59;
            Kanin = 12;
        }

        public override string ToString() => $"Apelsin: {Apelsin} Äpple: {Äpple} Kanin: {Kanin}";

    }
}
