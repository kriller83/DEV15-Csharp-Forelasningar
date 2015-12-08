using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7
{
    class Hat
    {
        private int size;
        private string color;

    public int Size
        {
            get { return size; }
            set
            {
                if (value >= 5 && value <= 15)
                    size = value;
                else
                    throw new Exception("Vi har ej storleken");
            }
        }
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
        public Hat(int size = 7, string color = "Brown")
        {
            Size = size;
            Color = color;
        }
        public override string ToString() => $"Size: {Size} Color: {Color}";
        
    }
}