using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasningar
{
    class Rectangle
    {
        int width;
        int height;

        public void SetWidth(int width)
        {
            this.width = width;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetCircumference()
        {
            int result = 2*width + 2*height; //Kan skriva double istället för int, exempelvis
            return result;
        }
        public int GetArea()
        {
            int AreaResult = width * height;
            return AreaResult;
        }

        internal string PrintRectangle()
        {
            return $"The cicumference is {this.GetCircumference()} and the area is {this.GetArea()}";
        }
    }
}
