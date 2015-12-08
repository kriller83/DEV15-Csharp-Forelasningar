using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8._3_hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A ab = new B(); //Den är ett A, men tror att den är ett B. Används som en härledd klass, kommer därför att använda sig av egen metod. 
            B b = new B();

            a.Print();
            ab.Print();
            b.Print();

            Console.ReadLine();
        }
    }
    class A
    {
        public void Print()
        {
            Console.WriteLine("Basklassen");
        }
    }
    class B : A
    {
        public new void Print()  //Namnkonflikt har uppstått. new gömmer metoden som finns i A. 
        {
            Console.WriteLine("Gömd metod i subklassen");
        }
    }
}