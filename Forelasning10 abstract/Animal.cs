using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning10_abstract  //Namespace djur (egentligen)
{
    abstract class Animal
    {
       public string Name { get; set; }

        public string Djur { get; set; }

        public int Age { get; set; }
        public abstract void PrintInfo();  //Vill du använda mig måste du använda en abstract metod. = override
        public override string ToString() => $"Name: {Name}, Age: {Age} Djur: {Djur}";   //Lambdavärde

        }
        //public virtual void PrintInfo(); Någon annan kan använda denna
    }

