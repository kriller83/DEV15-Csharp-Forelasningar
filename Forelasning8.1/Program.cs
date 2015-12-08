using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8._1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.internalProtected_string = "Nytt värde";
            myClass.internal_string = "Nytt värde igen";
            myClass.public_string = "Nytt värde etc";

        }
    }
}
