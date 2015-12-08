using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning10._1_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = MyStringExtension.Dotify("Hej");
            Console.WriteLine(name);
            Console.WriteLine("Kalle".Dotify());
            Console.WriteLine("Boris".Plussa());
            Console.WriteLine("hejhejhej".BigLetter());
            Console.ReadLine();
        }
        
    }
}
