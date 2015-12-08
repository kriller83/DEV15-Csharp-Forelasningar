using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutProject
{
    class Game
    {
        private int lives; //Backingfield
        private string name;
        public int Lives //Property skrivs i PascalCase
        {
            get { return lives; }
            set
            {
                if (value >= 0) //kan sätta villkor
                    lives = value; //value är istället för inparameter
            }
        }
        //skapa propertyn Name, kontrollera mot null i set 
        // sätt det till zelda i main...
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
            }
        }
    }
}
