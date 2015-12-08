using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8._1
{
    class SubClass : MyClass
    {
       //Har tillgång till allt utom private
        public void PrintAll()
        {
            base.public_string = "värde";
            base.internal_string = "";
            base.protected_string = "";
            base.internalProtected_string = "";

           /* SubClass subclass = new SubClass();*/  //KÄnns jättedumt.. 
        }
    }
}
