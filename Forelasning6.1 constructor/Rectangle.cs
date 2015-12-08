using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6._1_constructor
{
    class Rectangle
    {
        double height, width;

        public Rectangle(double height = 0, double width = 0)   //= 0 är per default
        {
            this.height = height;
            this.width = width;
        }
        /*skapa en rectangle som sätter 
            width och height i konstruktorn*/
    }
}
