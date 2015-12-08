using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning10_abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal cat = new Cat() { Name = "Kajsa", Djur = "Kisse", Age = 30 };
            //cat.PrintInfo();S
            Console.WriteLine(cat);
           Animal dog = new Dog() { Name = "Dogelito", Djur ="Vovve", Age = 23};
            //dog.PrintInfo();
            Console.WriteLine(dog);

            Console.ReadLine();
        }
    }
}
