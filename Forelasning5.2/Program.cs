using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //användaren skriver in ett tal
            string text = "4 eller något där omkring";
            int nummer;   //ni vill översätta användarens tal till ett heltalssvar
            bool validNumber = int.TryParse(text, out nummer);  //TryParse försöker att översätta. Går det så blir det true, annars false. 
            if(validNumber == false)    //Använd int.TryParse istället för int.Parse.. 
            {
                Console.WriteLine("inget giltigt nummer");
            }
            else
            {
                Console.WriteLine(3* nummer);
            }
            Console.ReadLine();
        }
    }
}
