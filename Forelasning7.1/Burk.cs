using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7._1
{
    //Prop 
    //Konstruktoranrop
    class Burk
    {
        public string Name { get; set; }
        public int Centiliter { get; set; }
        public double Height { get; set; }

        public Burk()
        {
            Name = "7up";
            Centiliter = 33;
            Height = 15.2;
        }
        //:this kastar vidare innan denna konstruktorn körs
        public Burk(string name, double height)
        {
            //Kan vara en klurig grej
            Name = name;
            Height = height;
        }
        //:this kastar vidare innan denna konstruktorn körs
        public Burk(int centiliter, double height, string name) : this(name, height)
        {
            Centiliter = centiliter;
 
        }
    }
}