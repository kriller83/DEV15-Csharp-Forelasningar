using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Burk sjuUp = new Burk(33, 15.2, "Zingo");
            Burk objectInitializerStyle = new Burk() { Name = "Heineken", Height = 4.2, Centiliter = 50 };
        }
    }
}
