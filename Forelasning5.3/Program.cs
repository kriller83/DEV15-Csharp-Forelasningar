using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "100";  //"100j" går ej.. scoopet körs ej då. 
            int tal;
            if(int.TryParse(text, out tal))
            {
                //Scoopet körs bara om giltigt text-värde går att översätta till int
                Console.WriteLine($"Talet är: {tal}");
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
