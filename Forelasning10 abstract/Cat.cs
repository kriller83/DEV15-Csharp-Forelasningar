using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning10_abstract
{
    class Cat : Animal  //Cat = quickactions
    {
        //public string MyProperty { get; private set; } = "Katt";
        private string djur = "Katt";

        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }

        //Sometimes pronunced as produkctinfo..
        public override string ToString() => $"Djur: {djur}" + base.ToString();

     
    }                   
}
