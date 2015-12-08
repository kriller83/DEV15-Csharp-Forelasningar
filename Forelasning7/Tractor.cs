using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    class Tractor
    {
        int wheels;  //Backing-field
        int steeringAngle;  //Backing-field

        public int Wheels  //Property. Stor bokstav i UML = property

        {
            get { return wheels; }
            set
            {
                if (value >= 3 && value <= 20)
                    this.wheels = value;   //Tänk på att sätta backingfield i propertyn här (wheels). Annars blir det stackoverflow... 
                else
                    throw new Exception("Fel värde. Måste vara 3-20");
            }
        }
        public int SteeringAngle  //Property
        {
            get { return steeringAngle; }
            set
            {
                steeringAngle = value % 360;
            }
        }
        public Tractor()  //Konstruktor. Har samma namn som classen. Ingen void eller liknande.. Byggs när new skapas.
        {
            Wheels = 4;
            SteeringAngle = 880;
        }
        public Tractor(int wheels)  //(överlagrad) Konstruktor. Anropas.. 
        {
            Wheels = wheels;
            SteeringAngle = 0;
        }
        public Tractor(int wheels, int steeringAngle)  //Konstruktor
        {
            Wheels = wheels;
            SteeringAngle = steeringAngle;
        }
        public override string ToString()  //Sist ligger alltid tostring. Om jag vill skriva ut. 
        {
            return $"Wheels: {Wheels} SteeringAngle: {SteeringAngle}";
        }
    }
    }

