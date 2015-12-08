using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning8._1;  //Reffar till ett annat projekt. I detta fallet Forelasning8. 

namespace Forelasning8._2_Ett_annat_projekt
{
    class Program
    {
        //Vi är nu i ett annat projekt där vi ska se vilka åtkomster vi har från Forelasning 8.1
        static void Main(string[] args)
        {
            MyClass myClassFromAnotherProject = new MyClass();
            myClassFromAnotherProject.public_string = "gurka";
        }
    }
}
