using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasningar
{
    class Boat
    {
        private string type;
        private int numberOfPassengers;

        public string GetType(){
            return type;
        }
        public void SetType(string type) {
            this.type = type;
        }
        public int GetNumberOfPassengers() {
            return numberOfPassengers;
        }
        public void SetNumberOfPassengers(int numberOfPassengers)
        {
            this.numberOfPassengers = numberOfPassengers;
        }
    }
}
