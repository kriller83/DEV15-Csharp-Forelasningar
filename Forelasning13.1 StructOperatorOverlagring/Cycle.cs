using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning13._1_StructOperatorOverlagring
{
    struct Cycle  //Ändra class till struct!!
    {
        private int val, min, max;   //Fält
        //Växlar vald, lägst högst...

        public Cycle(/*int val,*/ int min, int max)  //Konstruktor
        {
            //this.val = val;
            val = min;
            this.min = min;
            this.max = max;
        }

        public int Val       //Property med validation
        {            
            get { return val; }
            set
            {
                if (value >= min && value <= max)
                    val = value;
                val = min;
            }
        }

        public static Cycle operator +(Cycle cycle, int tal)
        {
            //Om klass gör vi så här:
            //Om vi skapat referenstyp/class måste vi skapa en kopia som vi returnerar så att inte det objekt som skickas in pekas på från 2 eller fler ställen...
            // return new Cycle(1, cycle.max += tal);

            //Titta närmre på stacken och heapen!!!! 

            cycle.max += tal;
            return cycle;

        }

    //public static Cycle operator +(Cycle cycle, int tal)  //Plusoperator. Skall överlagra.. Cykeln + ett tal blir Cykeln. 
    //    {
    //        cycle.min += tal;
    //        return cycle;
    //    }

        //public static Cycle operator -(Cycle cycle, int tal)  //Minusoperator   ..Cykeln minus ett tal blir Cykel
        //{
        //    cycle.max -= tal;
        //    return cycle;
        //}


        //public static Cycle operator +(int tal, Cycle cycle)
        //{
        //    cycle.max += tal;
        //    return cycle;
        //}

        //public static Cycle operator -(int tal, Cycle cycle)
        //{
        //    cycle.min -= tal;
        //    return cycle;
        //}

        public static int operator +(int tal, Cycle cycle)
        {
            tal += cycle.max;
            return tal;
        }


        public static Cycle operator *(Cycle cycle, int tal)
        {
            cycle.min *= tal;
            return cycle;
        }

        public static Cycle operator /(Cycle cycle, int tal)
        {
            cycle.max /= tal;
            return cycle;
        }


        public override string ToString()    //Override ToString
        {
            return $"Val:{Val} Min:{min} Max:{max}";
        }
    }
}
