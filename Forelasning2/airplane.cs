using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasningar
{
    class airplane
    {
        int wheels;

        public int GetWheels()
        {
            return wheels;
        }
        public void SetWheels(int wheels)
        {
            this.wheels = wheels;
        }

        internal string PrintAirplane()
        {
            return $"The airplane has {this.GetWheels()} wheels";
        }
    }
}

