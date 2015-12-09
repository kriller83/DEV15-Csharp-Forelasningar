using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning12_Inventarie
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"ProductName: {Name}, Quantity{Quantity}";
        }

        public int CompareTo(Product other)
        {
            return Quantity.CompareTo(other.Quantity);
        }
    }
}


//Kunna lägga till och ta bort saker. 
//Generiska listor senare..