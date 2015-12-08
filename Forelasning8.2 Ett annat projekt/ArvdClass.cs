using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning8._1;  //Reffar till Forelasning8.1

namespace Forelasning8._2_Ett_annat_projekt
{
    class ArvdClass : MyClass  //Hämtar MyClass
    {
        public void SomeSome()
        {
            base.public_string = "javisst";
            base.protected_string = "Jajjemen";
            base.internalProtected_string = "Jomen jadå";
        }
    }
}
