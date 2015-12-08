using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Vi skapar en mall som heter motorcyle
// Det kan skapas många kopior av denna mallen
//this pekar på en specifik kopia.
namespace Forelasningar
{
    class motorcycle  //internal class motorcyel. Behöver dock inte skriva internal
    {
        private int horsePowers;  //Behöver egentligen inte skriva private då det är detta per default.
        private int maxSpeed;

       //int horePowers, maxSpeed;
        public int GetHorsePowers(){  //kommer åt det utifrån med public
            return horsePowers;
        }
        public void SetHorsePowers(int horsePowers)  //Internal är mer åtstramat än public. Inom namespacet
        {
            this.horsePowers = horsePowers; //this -är den där uppe. Den specifika kopian/instansen (kan finnas många olika horsePowers)
        }
        public int GetMaxSpeed()
        {
            return maxSpeed;
        }
        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        internal string PrintMotorcyle()
        {
            return $"Boris har {this.GetHorsePowers()} horsepowers and {this.GetMaxSpeed()} in top speed";
        }
    }
}

//Skapa en motorcykel
//hästkrafter och maxhastighet
//getters och setters
//program som frågar efter egenskaperna och sätter dem i en instans
//utskrift av instansen