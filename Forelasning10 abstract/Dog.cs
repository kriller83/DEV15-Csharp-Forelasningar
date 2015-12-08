using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning10_abstract
{
    class Dog : Animal
    {
        public string djur = "Hund";

        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }
        public override string ToString() => $"NAme: {Name} Age {Age}" + base.ToString();
    }
}
