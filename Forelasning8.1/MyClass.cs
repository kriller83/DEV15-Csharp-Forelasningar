using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8._1
{
    //public sealed class MyClass
    //Kan lägga till sealed om man inte vill att MyClass skall kunna ärvas. Du kan använda den men inte ärva. 

        //Abstract säger att du måste ärva. Sealed säger att du inte får ärva. 
    public class MyClass   //Måste vara public för att kunna nås av(ärvas) andra projekt. 
    {
        //Åtkomstdirektiven!! Genomtänkta... hmm..
        private string private_string = "private";
        internal string internal_string = "internal";
        internal protected string internalProtected_string = "internal-protected";
        public string public_string = "public";
        protected string protected_string = "protected";
    }
}
