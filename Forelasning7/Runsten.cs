using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    public class Runsten
    {
        //Backing-fields
        string name;
        int weight;
        int age;

        //3 properties som valideras
        public string Name
        {
            get { return name; }  //Här validerar vi
            set
            {
                name = value;
            }
        }
        public int Weight
        {
            get { return weight; }  //Här validerar vi
            set
            {
                //if (value >= 100 && value <= 7000)
                var validValue = value >= 100 && value <= 7000;
                if (validValue)
                    this.weight = value;
                else
                    throw new Exception("Fel vikt, måste vara mellan 100 och 7000 kg");
            }
        }
        public int Age
        {
            get { return age; }  //Här validerar vi
            set
            {
                //if (value >= 400 && value <= 1200)
                var validValue = value >= 400 && value <= 1200;
                if (validValue)
                    this.age = value;
                else
                    throw new Exception("Fel värde, skall vara mellan 400 och 1200 år");
            }
        }

        //4 st konstruktorer
        public Runsten()
        {
            Name = "Tor";
            Weight = 450;
            Age = 500;
        }
        public Runsten (string name)  
        {
            Name = name;
            Weight = 600;
            Age = 700;
        }
        public Runsten(string name, int weight)
        {
            Name = name;
            Weight = weight;
            Age = 800;
        }
        public Runsten(string name, int weight, int age = 666) //Kan inte sätta tvingade värden längst till höger. Vi har satt age till et default värde.
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public override string ToString()
        {
            //Nyckel Name: och värde {Name}
            return $"Name: {Name} Weight: {Weight} Age: {Age}";
        }

    }
}
